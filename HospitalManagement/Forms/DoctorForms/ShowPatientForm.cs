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
    public partial class ShowPatientForm : Form
    {
        private ApplicationDbContext db;
        public ShowPatientForm()
        {
            InitializeComponent();
        }
        public ShowPatientForm(ApplicationDbContext db, Patient patient):this()
        {
            this.db = db;

            var patientPrescriptionsCount = db.Prescriptions
                .Where(p => p.PatientId == patient.Id)
                .Count();

            this.firstNameLabel.Text += patient.FirstName;
            this.middleNameLabel.Text += patient.MiddleName;
            this.lastNameLabel.Text += patient.LastName;
            this.prescriptionsAmountLabel.Text += patientPrescriptionsCount;
            if (patient.MedicalCondition!=null)
            {
                this.medicalConditionLabel.Text += patient.MedicalCondition.Name;
            }
            else
            {
                this.medicalConditionLabel.Text += "няма";
            }
        }
    }
}
