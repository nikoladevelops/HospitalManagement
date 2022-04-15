using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.Forms.AdminForms
{
    public partial class CreateDoctorForm : Form
    {
        private List<Control> createDoctorControls;
        private ApplicationDbContext db;

        public CreateDoctorForm()
        {
            InitializeComponent();
        }

        public CreateDoctorForm(ApplicationDbContext db):this()
        {
            this.db = db;
            LoadSpecialityListBoxData();
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

        private void PopulateCreateDoctorControls()
        {
            createDoctorControls = new List<Control>();
            createDoctorControls.Add(emailTextBox);
            createDoctorControls.Add(passwordTextBox);
            createDoctorControls.Add(firstNameTextBox);
            createDoctorControls.Add(middleNameTextBox);
            createDoctorControls.Add(lastNameTextBox);
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
    }
}
