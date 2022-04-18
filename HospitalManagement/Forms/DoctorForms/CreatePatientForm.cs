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

namespace HospitalManagement.Forms.DoctorForms
{
    public partial class CreatePatientForm : Form
    {
        private List<Control> createPatientControls;
        private ApplicationDbContext db;

        public CreatePatientForm()
        {
            InitializeComponent();
        }

        public CreatePatientForm(ApplicationDbContext db):this()
        {
            this.db = db;
            LoadMedicalConditionListBoxData();
            PopulateCreatePatientControls();
        }

        private void LoadMedicalConditionListBoxData()
        {
            medicalConditionListBox.Items.Clear();
            var allMedicalConditions = db.MedicalConditions.ToList();

            foreach (var medicalCondition in allMedicalConditions)
            {
                medicalConditionListBox.Items.Add(medicalCondition.Name);
            }
        }

        private void PopulateCreatePatientControls()
        {
            createPatientControls = new List<Control>();
            createPatientControls.Add(egnTextBox);
            createPatientControls.Add(firstNameTextBox);
            createPatientControls.Add(middleNameTextBox);
            createPatientControls.Add(lastNameTextBox);
        }

        private async void createPatientButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllInfoIsFilled())
            {
                MessageBox.Show("Моля попълни всички полета нужни за създаването на пациент!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ако егнто не е точно 10 символа ИЛИ на егнто всичките му символи НЕ са числа
                if (egnTextBox.Text.Length != 10 || !(egnTextBox.Text.All(char.IsDigit)))
                {
                    MessageBox.Show("Невалидно ЕГН. Егнто трябва да е точно 10 символа дълго и да съдържа само цифри", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // провери дали има пациент с регистрирано такова егн
                var patientAlreadyExists = db.Patients.FirstOrDefault(x => x.EGN == egnTextBox.Text);
                if (patientAlreadyExists != null)
                {
                    MessageBox.Show("Вече има регистриран пациент с такова ЕГН.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ако пациента НЕ съществува ще продъжи надолу

                // създай пациент
                var patient = new Patient()
                {
                    FirstName = firstNameTextBox.Text,
                    MiddleName = middleNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    EGN = egnTextBox.Text,
                };

                // ако има избрано заболяване за съответния пациент, запамети го
                if (medicalConditionListBox.SelectedIndex != -1)
                {
                    var medicalCondition = db.MedicalConditions.Single(x => x.Name == medicalConditionListBox.SelectedItem.ToString());
                    patient.MedicalConditionId = medicalCondition.Id;
                }

                await db.Patients.AddAsync(patient);
                await db.SaveChangesAsync();

                foreach (var control in createPatientControls)
                {
                    control.Text = "";
                }
                medicalConditionListBox.SelectedIndex = -1;

                MessageBox.Show("Вие успешно създадохте нов пациент. Вече можете да му изписвате рецепти.", "Успешно създаден пациент.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckIfAllInfoIsFilled()
        {
            foreach (var control in createPatientControls)
            {
                // за всеки един TextBox ако текста само на един даже да не е попълнен
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    // върни false че не е попълнен
                    return false;
                }

            }
            // ако всички полета за добавяне на пациент са попълнени коректно върни true
            return true;
        }
    }
}
