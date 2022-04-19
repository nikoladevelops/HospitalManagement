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
    public partial class ShowPrescriptionsOfPatient : Form
    {
        private ApplicationDbContext db;

        public ShowPrescriptionsOfPatient()
        {
            InitializeComponent();
        }

        public ShowPrescriptionsOfPatient(ApplicationDbContext db, Patient patient):this()
        {
            this.db = db;

            this.egnTextBox.Text = patient.EGN;
            var allPatientPrescriptions = db.Prescriptions.Where(p => p.PatientId == patient.Id).ToList();
            if (allPatientPrescriptions.Count==0)
            {
                allPatientPrescriptionsListBox.Items.Add("няма");
                prescriptionTextBox.Text = "няма";
            }
            else
            {
                foreach (var prescription in allPatientPrescriptions)
                {
                    allPatientPrescriptionsListBox.Items.Add(prescription.Id);
                }
                allPatientPrescriptionsListBox.SelectedIndexChanged += allPatientPrescriptionsListBox_SelectedIndexChanged;
            }
        }

        private void allPatientPrescriptionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prescriptionId = (int)allPatientPrescriptionsListBox.SelectedItem;
            var prescription = db.Prescriptions.Single(p => p.Id == prescriptionId);
            prescriptionTextBox.Text = prescription.PrescriptionText;
        }
    }
}
