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
    public partial class SearchPatientForm : Form
    {
        private ApplicationDbContext db;
        private Action<Form> openChildForm;
        public SearchPatientForm()
        {
            InitializeComponent();
        }
        public SearchPatientForm(ApplicationDbContext db, Action<Form> openChildForm) : this()
        {
            this.db = db;
            this.openChildForm = openChildForm;
            PopulateSearchCriteriaListBox();
        }
        private void PopulateSearchCriteriaListBox()
        {
            searchCriteriaListBox.Items.Add("ЕГН");
            searchCriteriaListBox.Items.Add("Първо име");
            searchCriteriaListBox.Items.Add("Презиме");
            searchCriteriaListBox.Items.Add("Фамилия");
            searchCriteriaListBox.Items.Add("Заболяване");
        }
        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Моля попълнете полето за търсене на пациент", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchCriteriaListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете критерий по който да се извърши търсенето на пациент.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundPatientsList = new List<Patient>();
            var searchCriteria = searchCriteriaListBox.SelectedItem.ToString();
            var searchTerm = searchTextBox.Text;
            switch (searchCriteria)
            {
                case "ЕГН":
                    {
                        var patient = db.Patients.SingleOrDefault(p => p.EGN == searchTerm);
                        if (patient != null)
                        {
                            foundPatientsList.Add(patient);
                        }
                        break;
                    }
                case "Първо име":
                    {
                        var patients = db.Patients.Where(p => p.FirstName == searchTerm).ToList();
                        foreach (var patient in patients)
                        {
                            foundPatientsList.Add(patient);
                        }
                        break;
                    }
                case "Презиме":
                    {
                        var patients = db.Patients.Where(p => p.MiddleName == searchTerm).ToList();
                        foreach (var patient in patients)
                        {
                            foundPatientsList.Add(patient);
                        }
                        break;
                    }
                case "Фамилия":
                    {
                        var patients = db.Patients.Where(p => p.LastName == searchTerm).ToList();
                        foreach (var patient in patients)
                        {
                            foundPatientsList.Add(patient);
                        }
                        break;
                    }
                case "Заболяване":
                    {
                        var medicalCondition = db.MedicalConditions.SingleOrDefault(x => x.Name == searchTerm.ToUpper());
                        if (medicalCondition == null)
                        {
                            MessageBox.Show("Таково заболяване не съществува.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var patients = db.Patients.Include(p=>p.MedicalCondition).Where(p => p.MedicalCondition.Name == searchTerm.ToUpper()).ToList();
                        foreach (var patient in patients)
                        {
                            foundPatientsList.Add(patient);
                        }
                        break;
                    }
                default:
                    return;

            }

            if (foundPatientsList.Count() == 0)
            {
                foundPatientsListBox.Items.Clear();
                MessageBox.Show("Няма намерени пациенти по този критерий.", "Не бяха намерени пациенти.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foundPatientsListBox.Items.Clear();

                foreach (var patient in foundPatientsList)
                {
                    foundPatientsListBox.Items.Add(patient.EGN);
                }
                MessageBox.Show("Бяха намерени " + foundPatientsList.Count() + " пациента.", "Има намерени пациенти.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private bool CheckIfPatientSelected()
        {
            if (foundPatientsListBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private Patient GetSelectedPatient()
        {
            var selectedPatientEGN = foundPatientsListBox.SelectedItem.ToString();
            // .Single() тъй като егн-тата неможе да са еднакви на двама пациента
            // .Include() зада заредим заболяването на пациента/ ако той има такова ествествено
            return db.Patients.Include(p=>p.MedicalCondition).Single(p => p.EGN == selectedPatientEGN);
        }
        private void showSelectedPatientButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfPatientSelected())
            {
                MessageBox.Show("Трябва да изберете пациент първо.", "Не сте избрали пациент.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedPatient = GetSelectedPatient();
            openChildForm(new ShowPatientForm(db, selectedPatient));
        }
        private void editSelectedPatientButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfPatientSelected())
            {
                MessageBox.Show("Трябва да изберете пациент първо.", "Не сте избрали пациент.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedPatient = GetSelectedPatient();
            openChildForm(new EditPatientForm(db, selectedPatient));
        }

        private async void deleteSelectedPatientButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfPatientSelected())
            {
                MessageBox.Show("Трябва да изберете пациент първо.", "Не сте избрали пациент.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedPatient = GetSelectedPatient();
            var result = MessageBox.Show("Вмомента сте на път да изтриете пациента с ЕГН " + selectedPatient.EGN + ". Това ще изтрие и всичките му рецепти. Искате ли да изтриете този пациент?", "Сигурни ли сте че искате да изтриете този пациент?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var patientToDelete = db.Patients.Single(p => p.EGN == selectedPatient.EGN);
                db.Patients.Remove(patientToDelete);
                await db.SaveChangesAsync();
                foundPatientsListBox.Items.Remove(patientToDelete.EGN);
            }
        }

        private void createSelectedPatientPrescription_Click(object sender, EventArgs e)
        {
            if (!CheckIfPatientSelected())
            {
                MessageBox.Show("Трябва да изберете пациент първо.", "Не сте избрали пациент.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
