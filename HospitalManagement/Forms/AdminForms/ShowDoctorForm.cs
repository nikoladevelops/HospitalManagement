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
    public partial class ShowDoctorForm : Form
    {
        private ApplicationDbContext db;
        public ShowDoctorForm()
        {
            InitializeComponent();
        }
        // тази форма трябва да се ползва само със User-и, които са в роля Doctor
        // ако сложим user с друга роля ще получим грешка, имай го на предвид
        public ShowDoctorForm(ApplicationDbContext db, User user):this()
        {
            this.db = db;
            this.emailLabel.Text += user.Email;
            this.passwordLabel.Text += user.Password;
            // вземи информацията на доктора за съответния user
            // знаем че ползваме .Single() понеже имаме връзка едно към едно
            // точно това би хвърлило грешката ако user-а всъщност няма докторски акаунт
            var doctorInfo = db.Doctors
                .Include(d => d.DoctorSpeciality)
                .Single(d => d.UserId == user.Id);

            // вземи колко рецепти е изписал този доктор
            var doctorPrescriptionCount = db.Prescriptions
                .Where(p => p.DoctorId == doctorInfo.Id)
                .Count();

            this.firstNameLabel.Text += doctorInfo.FirstName;
            this.middleNameLabel.Text += doctorInfo.MiddleName;
            this.lastNameLabel.Text += doctorInfo.LastName;
            this.specialityLabel.Text += doctorInfo.DoctorSpeciality.Name;
            this.prescriptionsAmountLabel.Text += doctorPrescriptionCount;


        }
    }
}
