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
    public partial class MedicalConditionForm : Form
    {
        private ApplicationDbContext db;

        public MedicalConditionForm()
        {
            InitializeComponent();
        }

        public MedicalConditionForm(ApplicationDbContext db):this()
        {
            this.db = db;
            LoadMedicalConditionListBoxData();
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

        private async void createMedicalConditionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(medicalConditionNameTextBox.Text))
            {
                MessageBox.Show("Въведи име за новото заболяване!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // винаги запаметяваме заболяванията с главни букви -> .ToUpperInvariant()
                var medicalCondition = new MedicalCondition()
                {
                    Name = medicalConditionNameTextBox.Text.ToUpperInvariant()
                };

                if (db.MedicalConditions.FirstOrDefault(x => x.Name == medicalCondition.Name) != null)
                {
                    MessageBox.Show("Вече съществува такова заболяване!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await db.MedicalConditions.AddAsync(medicalCondition);
                    await db.SaveChangesAsync();
                    LoadMedicalConditionListBoxData();
                    MessageBox.Show("Вие успешно създадохте ново заболяване. Вече можете да създавате пациенти, които го притежават!", "Успешно създадено ново заболяване.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private async void deleteMedicalConditionButton_Click(object sender, EventArgs e)
        {
            if (medicalConditionListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете заболяване, което желаете да изтриете.", "Изберете заболяване за изтриване.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Наистина ли искате да изтриете това заболяване? Всички пациенти страдащи от него вече няма да го имат. Искате ли да продължите?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // дай ми единственото заболяване с такова име
                    var selectedMedicalCondition = db.MedicalConditions.Single(x => x.Name == medicalConditionListBox.SelectedItem.ToString());
                    var patientsWithMedicalCondition = db.Patients.Include(x => x.MedicalCondition).Where(x => x.MedicalConditionId == selectedMedicalCondition.Id);
                    foreach (var patient in patientsWithMedicalCondition)
                    {
                        patient.MedicalConditionId = null;
                    }
                    db.MedicalConditions.Remove(selectedMedicalCondition);
                    await db.SaveChangesAsync();
                    LoadMedicalConditionListBoxData();
                }
            }
        }
    }
}
