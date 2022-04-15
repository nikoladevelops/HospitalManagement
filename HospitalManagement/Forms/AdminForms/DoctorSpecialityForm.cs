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
    public partial class DoctorSpecialityForm : Form
    {
        private ApplicationDbContext db;

        public DoctorSpecialityForm()
        {
            InitializeComponent();
        }

        public DoctorSpecialityForm(ApplicationDbContext db):this()
        {
            this.db = db;
            LoadSpecialityListBoxData();
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

        private async void createSpecialityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(specialityNameTextBox.Text))
            {
                MessageBox.Show("Въведи име за новата специалност!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var speciality = new DoctorSpeciality()
                {
                    Name = specialityNameTextBox.Text.ToUpperInvariant()
                };

                if (db.DoctorSpecialities.FirstOrDefault(x => x.Name == speciality.Name) != null)
                {
                    MessageBox.Show("Вече съществува такава докторска специалност!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await db.DoctorSpecialities.AddAsync(speciality);
                    await db.SaveChangesAsync();
                    LoadSpecialityListBoxData();
                    MessageBox.Show("Вие успешно създадохте нова докторска специалност. Вече можете да създавате доктори, които я притежават!", "Успешно създадена специалност за доктори", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private async void deleteSpecialityButton_Click(object sender, EventArgs e)
        {
            if (specialityListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете специалност, която желаете да изтриете.", "Изберете специалност за изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Ако изтриете тази докторска специалност и има доктори, които я имат, и те ще бъдат изтрити заедно с нея! Искате ли да продължите въпреки това?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var selectedSpeciality = db.DoctorSpecialities.Single(x => x.Name == specialityListBox.SelectedItem.ToString());
                    db.DoctorSpecialities.Remove(selectedSpeciality);
                    await db.SaveChangesAsync();
                    LoadSpecialityListBoxData();
                }
            }
        }
    }
}
