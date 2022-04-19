using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class EditDoctorForm : Form
    {
        private ApplicationDbContext db;
        private List<Control> editDoctorControls;
        private User userInfoToEdit;
        private Doctor doctorInfoToEdit;
        public EditDoctorForm()
        {
            InitializeComponent();
        }
        // тази форма трябва да се ползва само със User-и, които са в роля Doctor
        // ако сложим user с друга роля ще получим грешка, имай го на предвид
        public EditDoctorForm(ApplicationDbContext db, User user):this()
        {
            this.db = db;
            LoadSpecialityListBoxData();
            PopulateEditDoctorControls();

            // вземи информацията на доктора за съответния user
            // знаем че ползваме .Single() понеже имаме връзка едно към едно
            // точно това би хвърлило грешката ако user-а всъщност няма докторски акаунт
            var doctorInfo = db.Doctors
                .Include(d => d.DoctorSpeciality)
                .Single(d => d.UserId == user.Id);

            // сложи индекса на избраната специалност да е специалността на доктора
            var index = this.specialityListBox.Items.IndexOf(doctorInfo.DoctorSpeciality.Name);
            specialityListBox.SelectedIndex = index;

            // попълни и другите данни на доктора
            emailTextBox.Text = user.Email;
            passwordTextBox.Text = user.Password;
            firstNameTextBox.Text = doctorInfo.FirstName;
            middleNameTextBox.Text=doctorInfo.MiddleName;
            lastNameTextBox.Text = doctorInfo.LastName;

            this.userInfoToEdit = user;
            this.doctorInfoToEdit = doctorInfo;

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

        private void PopulateEditDoctorControls()
        {
            editDoctorControls = new List<Control>();
            editDoctorControls.Add(emailTextBox);
            editDoctorControls.Add(passwordTextBox);
            editDoctorControls.Add(firstNameTextBox);
            editDoctorControls.Add(middleNameTextBox);
            editDoctorControls.Add(lastNameTextBox);
        }

        private async void editDoctorButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllInfoIsFilled())
            {
                MessageBox.Show("Моля попълни всички полета нужни за редактиране на доктор!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dbUser = db.Users.Single(u => u.Id == userInfoToEdit.Id);
                var dbDoctor = db.Doctors.Single(d => d.Id == doctorInfoToEdit.Id);

                var currentSelectedSpeciality = specialityListBox.SelectedItem.ToString();
                var doctorSpeciality = db.DoctorSpecialities.Single(x => x.Name == currentSelectedSpeciality);

                // редактирай User профила на доктора

                // провери дали вече има друг user с такъв имейл

                var dbUserWithNewEmail = db.Users.SingleOrDefault(u => u.Email == emailTextBox.Text);
                // ако не е NULL значи има такъв user с такъв имейл
                if (dbUserWithNewEmail != null) 
                {
                    // ако Id-то на Userа който едитваме НЕ Е равно на Id-то на usera с новия имейл
                    // то тогава значи че това са два различни Usera
                    // тоест вече има регистриран User с този имейл
                    // и съответно не можем да променим този който редактираме на него.
                    if (dbUser.Id != dbUserWithNewEmail.Id)
                    {
                        MessageBox.Show("Вече има такъв регистриран потребител с този имейл. Моля пробвайте друг.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                dbUser.Email = emailTextBox.Text;
                dbUser.Password = passwordTextBox.Text;

                await db.SaveChangesAsync();

                // редактирай самата информация на доктора
                dbDoctor.FirstName = firstNameTextBox.Text;
                dbDoctor.MiddleName = middleNameTextBox.Text;
                dbDoctor.LastName = lastNameTextBox.Text;
                dbDoctor.DoctorSpecialityId = doctorSpeciality.Id;

                await db.SaveChangesAsync();

                MessageBox.Show("Вие успешно редактирахте този докторски акаунт.", "Успешно редактиран докторски акаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckIfAllInfoIsFilled()
        {
            // ако не е избрана специалност за доктора
            if (specialityListBox.SelectedIndex == -1)
            {
                return false;
            }

            foreach (var control in editDoctorControls)
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
