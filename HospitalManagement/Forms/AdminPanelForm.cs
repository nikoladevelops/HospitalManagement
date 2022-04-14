using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Forms
{
    public partial class AdminPanelForm : Form
    {
        private ApplicationDbContext db;
        private List<Control> createDoctorControls;
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        public AdminPanelForm(User user):this()
        {
            this.db = new ApplicationDbContext();
            LoadSpecialityListBoxData();
            displayEmailLabel.Text = "Влезли сте като: " + user.Email;
            PopulateSearchCriteriaListBox();
            PopulateCreateDoctorControls();
            
        }

        private void PopulateCreateDoctorControls()
        {
            createDoctorControls = new List<Control>();
            createDoctorControls.Add(emailTextBox);
            createDoctorControls.Add(passwordTextBox);
            createDoctorControls.Add(firstNameTextBox);
            createDoctorControls.Add(middleNameTextBox);
            createDoctorControls.Add(lastNameTextBox);
        }

        private void PopulateSearchCriteriaListBox()
        {
            searchCriteriaListBox.Items.Add("Имейл");
            searchCriteriaListBox.Items.Add("Първо име");
            searchCriteriaListBox.Items.Add("Презиме");
            searchCriteriaListBox.Items.Add("Фамилия");
            searchCriteriaListBox.Items.Add("Специалност");
        }

        private async void createDoctorButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllInfoIsFilled())
            {
                MessageBox.Show("Моля попълни всички полета нужни за създаването на доктор!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var userAlreadyExists = db.Users.FirstOrDefault(x => x.Email == emailTextBox.Text);
                if (userAlreadyExists != null) 
                {
                    MessageBox.Show("Вече има регистриран User с такъв имейл.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ако ролята doctor не съществува ще хвърли грешка,
                // което е напълно коректно, тъй като предстоящата логика
                // е за доктори
                var doctorRole = db.Roles.Single(x => x.Name.ToLower() == "doctor");

                var user = new User()
                {
                    Email = emailTextBox.Text,
                    Password = passwordTextBox.Text,
                    RoleId = doctorRole.Id
                };

                var savedUser = await db.AddAsync(user);
                await db.SaveChangesAsync();

                var currentSelectedSpeciality = specialityListBox.SelectedItem.ToString();

                // тук отново метода .Single() би хвърлил грешка ако не бъде намерена докторска специалност
                // или има повече от 1 докторска специалност с такова име
                var doctorSpeciality = db.DoctorSpecialities.Single(x => x.Name == currentSelectedSpeciality);
                var doctor = new Doctor()
                {
                    FirstName = firstNameTextBox.Text,
                    MiddleName = middleNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    UserId = savedUser.Entity.Id,
                    DoctorSpecialityId = doctorSpeciality.Id
                };

                await db.Doctors.AddAsync(doctor);
                await db.SaveChangesAsync();

                foreach (var control in createDoctorControls)
                {
                    control.Text = "";
                }
                specialityListBox.SelectedIndex = -1;

                MessageBox.Show("Вие успешно създадохте нов докторски акаунт. Този доктор вече може да влиза с въведените от вас имейл и парола.", "Успешно създаден докторски акаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckIfAllInfoIsFilled()
        {
            // ако не е избрана специалност за доктора
            if (specialityListBox.SelectedIndex == -1)
            {
                return false;
            }

            // TODO implement show selected doctor info
            // TODO implement edit selected doctor info
            // TODO implement delete selected doctor / warning of deleting all his prescriptions

            foreach (var control in createDoctorControls)
            {
                // за всеки един TextBox ако текста само на един даже да не е попълнен
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    // върни false че не е попълнен
                    return false;
                }
                
            }
            // ако всички полета за добавяне на доктор са попълнени коректно върни true
            return true;
        }
        private async void createSpecialityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(specialityNameTextBox.Text))
            {
                MessageBox.Show("Въведи име за новата специалност!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var speciality = new DoctorSpeciality()
                {
                    Name = specialityNameTextBox.Text.ToUpperInvariant()
                };

                if (db.DoctorSpecialities.FirstOrDefault(x=>x.Name == speciality.Name) !=null)
                {
                    MessageBox.Show("Вече съществува такава докторска специалност!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await db.DoctorSpecialities.AddAsync(speciality);
                    await db.SaveChangesAsync();
                    LoadSpecialityListBoxData();
                    MessageBox.Show("Вие успешно създадохте нова докторска специалност. Вече можете да създавате доктори, които я притежават!", "Успешно създадена специалност за доктори", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadSpecialityListBoxData()
        {
            specialityListBox.Items.Clear();
            var allDoctorSpecialities = db.DoctorSpecialities.ToList();

            foreach (var speciality in allDoctorSpecialities)
            {
                specialityListBox.Items.Add(speciality.Name);
            }
        }

        private async void deleteSpecialityButton_Click(object sender, EventArgs e)
        {
            if (specialityListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Моля изберете специалност, която желаете да изтриете.","Изберете специалност за изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Ако изтриете тази докторска специалност и има доктори, които я имат, и те ще бъдат изтрити заедно с нея! Искате ли да продължите въпреки това?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var selectedSpeciality = db.DoctorSpecialities.Single(x => x.Name == specialityListBox.SelectedItem.ToString());
                    db.DoctorSpecialities.Remove(selectedSpeciality);
                    await db.SaveChangesAsync();
                    LoadSpecialityListBoxData();
                }
            }
        }

        private void searchDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Моля попълнете полето за търсене на доктор", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchCriteriaListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете критерий по който да се извърши търсенето на доктор.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundDoctorsList = new List<Doctor>();
            var searchCriteria = searchCriteriaListBox.SelectedItem.ToString();
            var searchTerm = searchTextBox.Text;
            switch (searchCriteria)
            {
                case "Имейл":
                    {
                        // намери дали такъв User е регистриран с този имейл
                        // ползваме SingleOrDefault тъй като
                        // трябва да имаме само един User с такъв имейл
                        // ако не бъде намерен 1 такъв User, то ми върни NULL
                        // също така зареди ми Role полето на User-а с .Include() че да имам достъп до името на ролята на usera
                        var user = db.Users.Include(u => u.Role).SingleOrDefault(u => u.Email == searchTerm);
                        if (user != null)
                        {
                            // ако ролята е доктор
                            if (user.Role.Name.ToLower() == "doctor")
                            {
                                // намери информацията за доктора, който отговаря на съответния user
                                // използваме Single(), тъй като връзката ни е едно към едно
                                // и не би трябвало да има друг доктор с Id на намерения user
                                // всеки един доктор отговаря на точно един user - не по малко/ не повече

                                var doctor = db.Doctors.Single(d => d.UserId == user.Id);
                                foundDoctorsList.Add(doctor);
                            }
                            // ако ролята не му е доктор, не бива да го добавяме към списъка с намерени доктори
                        }
                        break;
                    }
                case "Първо име":
                    {
                        // ползваме .Where за да намерим колекция от доктори, които притежават това име
                        var doctors = db.Doctors.Where(d => d.FirstName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Презиме":
                    {
                        var doctors = db.Doctors.Where(d => d.MiddleName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Фамилия":
                    {
                        var doctors = db.Doctors.Where(d => d.LastName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Специалност":
                    {
                        // отново ползваме SingleOrDefault
                        // защото би трябвало да имаме не повече от 1 специалност с такова име в базата
                        // и защото ако не бъде намерена 1 специалност, то да ми върне NULL

                        var doctorSpeciality = db.DoctorSpecialities.SingleOrDefault(x => x.Name == searchTerm.ToUpper());
                        if (doctorSpeciality == null)
                        {
                            MessageBox.Show("Такава докторска специалност не съществува.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var doctors = db.Doctors.Include(d=>d.DoctorSpeciality).Where(d => d.DoctorSpeciality.Name == searchTerm.ToUpper()).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                default:
                    // тука даже не би трябвало да стигне програмата тъй като имаме
                    // само тези 5 неща в searchCriteriaListBox заредени
                    return;

            }

            if (foundDoctorsList.Count() == 0)
            {
                foundDoctorsListBox.Items.Clear();
                MessageBox.Show("Няма намерени доктори по този критерий.", "Не бяха намерени доктори.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foundDoctorsListBox.Items.Clear();

                foreach (var doctor in foundDoctorsList)
                {
                    // зареди ми имейла на User профила на намерения доктор
                    // ползваме Single() тъй като знаем че щом имаме намерени доктори
                    // всеки един от тях принадлежи само на един User профил
                    // нямаме един User профил, който да може да се използва от много доктори
                    // тъй като отново -> имаме връзка едно към едно
                    // един User съответства на един Doctor
                    // и е невъзможно един и същи User да отговаря на повече от един доктор
                    // заради дизайна на базата (foreign key-a към User-ите е UNIQUE, не може да се повтаря)
                    var user = db.Users.Single(x => x.Id == doctor.UserId);
                    foundDoctorsListBox.Items.Add(user.Email);
                }
                MessageBox.Show("Бяха намерени " + foundDoctorsList.Count() + " доктора.", "Има намерени доктори.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void showSelectedDoctorButton_Click(object sender, EventArgs e)
        {
            // open show doctor form
        }

        private void deleteSelectedDoctorButton_Click(object sender, EventArgs e)
        {
            // open delete doctor messagebox
        }

        private void editSelectedDoctorButton_Click(object sender, EventArgs e)
        {
            // open edit doctor form
        }
        private bool CheckIfDoctorSelected() 
        {
            if (foundDoctorsListBox.SelectedIndex==-1)
            {
                return false;
            }
            return true;
        }

    }
}
