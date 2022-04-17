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
    public partial class ShowDoctorForm : Form
    {
        private ApplicationDbContext db;
        public ShowDoctorForm()
        {
            InitializeComponent();
        }
        public ShowDoctorForm(ApplicationDbContext db, User user):this()
        {
            this.db = db;
            this.label1.Text = user.Email;
        }
    }
}
