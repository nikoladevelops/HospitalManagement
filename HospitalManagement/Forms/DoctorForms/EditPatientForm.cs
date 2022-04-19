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

namespace HospitalManagement.Forms.DoctorForms
{
    public partial class EditPatientForm : Form
    {
        private ApplicationDbContext db;
        private List<Control> editPatientControls;
        private Patient patientInfoToEdit;
        public EditPatientForm()
        {
            InitializeComponent();
        }
        public EditPatientForm(ApplicationDbContext db, Patient patient):this()
        {
            this.db = db;
            LoadMedicalConditionListBoxData();
            PopulateEditPatientControls();

            // ако пациента има заболяване
            if (patient.MedicalCondition != null)
            {
                // сложи индекса на избраното заболяване да е заболяването на пациента
                var index = this.medicalConditionListBox.Items.IndexOf(patient.MedicalCondition.Name);
                medicalConditionListBox.SelectedIndex = index;
            }
            else
            {
                // тъй като знаем че опцията НЯМА e index 0
                medicalConditionListBox.SelectedIndex = 0;
            }

            // попълни и другите данни на пациента
            egnTextBox.Text = patient.EGN;
            firstNameTextBox.Text = patient.FirstName;
            middleNameTextBox.Text = patient.MiddleName;
            lastNameTextBox.Text = patient.LastName;

            this.patientInfoToEdit = patient;

        }

        private void LoadMedicalConditionListBoxData()
        {
            medicalConditionListBox.Items.Clear();
            var allMedicalConditions = db.MedicalConditions.ToList();

            // това винаги ще е index 0
            medicalConditionListBox.Items.Add("НЯМА");

            foreach (var medicalCondition in allMedicalConditions)
            {
                medicalConditionListBox.Items.Add(medicalCondition.Name);
            }
        }

        private void PopulateEditPatientControls()
        {
            editPatientControls = new List<Control>();
            editPatientControls.Add(egnTextBox);
            editPatientControls.Add(firstNameTextBox);
            editPatientControls.Add(middleNameTextBox);
            editPatientControls.Add(lastNameTextBox);
        }

        private async void editPatientButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfAllInfoIsFilled())
            {
                MessageBox.Show("Моля попълни всички полета нужни за редактиране на пациент!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ако егнто не е точно 10 символа ИЛИ на егнто всичките му символи НЕ са числа
                if (egnTextBox.Text.Length != 10 || !(egnTextBox.Text.All(char.IsDigit)))
                {
                    MessageBox.Show("Невалидно ЕГН. Егнто трябва да е точно 10 символа дълго и да съдържа само цифри", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dbPatient = db.Patients.Single(p => p.Id == patientInfoToEdit.Id);
                var currentSelectedMedicalCondition = medicalConditionListBox.SelectedItem.ToString();
                if (currentSelectedMedicalCondition != "НЯМА")
                {
                    var patientMedicalCondition = db.MedicalConditions.Single(x => x.Name == currentSelectedMedicalCondition);
                    dbPatient.MedicalConditionId = patientMedicalCondition.Id;
                }
                else
                {
                    dbPatient.MedicalConditionId = null;
                }

                // провери дали вече има друг patient с такова EGN

                var dbPatientWithNewEGN = db.Patients.SingleOrDefault(p => p.EGN == egnTextBox.Text);
                // ако не е NULL значи има такъв пациент с такова EGN
                if (dbPatientWithNewEGN != null) 
                {
                    // тази проверка я правим, понеже когато доктор редактира пациент
                    // той може да иска да му смени всичко останало освен ЕГНто
                    // провери дали това егн принадлежи на пациента, който редактираме сега
                    // ако това егн принадлежи на друг пациент, то тогава хвърли грешка
                    // понеже не може да имаме 2 еднакви егн-та в базата
                    // а ако егн-то е на пациента, който редактираме вмомента няма никакъв проблем
                    // мини нататък и го редактирай
                    if (dbPatient.Id != dbPatientWithNewEGN.Id)
                    {
                        MessageBox.Show("Вече има пациент с такова ЕГН.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // редактирай информацията на пациента
                dbPatient.EGN = egnTextBox.Text;
                dbPatient.FirstName = firstNameTextBox.Text;
                dbPatient.MiddleName = middleNameTextBox.Text;
                dbPatient.LastName = lastNameTextBox.Text;
                await db.SaveChangesAsync();

                MessageBox.Show("Вие успешно редактирахте информацията на този пациент.", "Успешно редактиран пациент", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckIfAllInfoIsFilled()
        {
            foreach (var control in editPatientControls)
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
