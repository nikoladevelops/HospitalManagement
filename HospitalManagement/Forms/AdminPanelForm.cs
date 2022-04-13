using HospitalManagement.Models;

namespace HospitalManagement.Forms
{
    public partial class AdminPanelForm : Form
    {
        private ApplicationDbContext db;
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
            
        }

        private void PopulateSearchCriteriaListBox()
        {
            searchCriteriaListBox.Items.Add("Имейл");
            searchCriteriaListBox.Items.Add("Име");
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
                    // error user already exists - имейла трябва да е уникален
                    return;
                }

                var doctorRole = db.Roles.Single(x => x.Name.ToLower() == "doctor");

                var user = new User()
                {
                    Email = emailTextBox.Text,
                    Password = passwordTextBox.Text,
                    RoleId = doctorRole.Id
                };

                var savedUser = await db.AddAsync(user);
                await db.SaveChangesAsync();

                var doctorSpeciality = db.DoctorSpecialities.Single(x => x.Name.ToLower() == specialityListBox.Text.ToLower());
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
            }
        }

        private bool CheckIfAllInfoIsFilled()
        {
            // ако не е избрана специалност за доктора
            if (specialityListBox.SelectedIndex == -1)
            {
                return false;
            }

            foreach (var control in this.Controls)
            {
                var txtBox = control as TextBox;
                if (txtBox != null) // ако не е NULL значи верно е TextBox
                {
                    // specialityNameTextBox не е нужен за създаване на доктор, затова го пропусни
                    if (txtBox.Name==specialityNameTextBox.Name)
                    {
                        continue;
                    }

                    // за всеки един TextBox ако текста само на един даже да не е попълнен
                    if (string.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        // върни false че не е попълнен
                        return false;
                    }
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
                    Name = specialityNameTextBox.Text
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
                MessageBox.Show("Моля изберете специалност, която желаете да изтриете.","Изберете специалност за изтриване", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
