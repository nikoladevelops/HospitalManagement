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
    public partial class CreatePrescriptionForm : Form
    {
        private ApplicationDbContext db;
        private int doctorId;
        private int patientId;

        public CreatePrescriptionForm()
        {
            InitializeComponent();
        }

        // доктор Id и patient Id трябва винаги да са валидни
        public CreatePrescriptionForm(ApplicationDbContext db, int doctorId, Patient patient):this()
        {
            this.db = db;
            this.doctorId = doctorId;
            this.patientId = patient.Id;

            this.egnTextBox.Text = patient.EGN;
            this.firstNameTextBox.Text = patient.FirstName;
            this.middleNameTextBox.Text = patient.MiddleName;
            this.lastNameTextBox.Text = patient.LastName;
        }
        private async void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prescriptionTextBox.Text))
            {
                MessageBox.Show("Рецептата не може да бъде празна. Моля попълнете я.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var prescription = new Prescription()
            {
                DoctorId = doctorId,
                PatientId = patientId,
                PrescriptionText = prescriptionTextBox.Text,
                DateCreated = DateTime.UtcNow.ToShortDateString()
            };

            await db.Prescriptions.AddAsync(prescription);
            await db.SaveChangesAsync();
            prescriptionTextBox.Text = "";
            MessageBox.Show("Успешно създадохте рецепта за този пациент.", "Успешно създадена рецепта.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
