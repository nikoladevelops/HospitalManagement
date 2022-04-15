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
    public partial class SearchDoctorForm : Form
    {
        private ApplicationDbContext db;

        public SearchDoctorForm()
        {
            InitializeComponent();
        }

        public SearchDoctorForm(ApplicationDbContext db) : this()
        {
            this.db = db;
            PopulateSearchCriteriaListBox();
        }

        private void PopulateSearchCriteriaListBox()
        {
            searchCriteriaListBox.Items.Add("Имейл");
            searchCriteriaListBox.Items.Add("Първо име");
            searchCriteriaListBox.Items.Add("Презиме");
            searchCriteriaListBox.Items.Add("Фамилия");
            searchCriteriaListBox.Items.Add("Специалност");
        }

        private void searchDoctorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Моля попълнете полето за търсене на доктор", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchCriteriaListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Моля изберете критерий по който да се извърши търсенето на доктор.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundDoctorsList = new List<Doctor>();
            var searchCriteria = searchCriteriaListBox.SelectedItem.ToString();
            var searchTerm = searchTextBox.Text;
            switch (searchCriteria)
            {
                case "Имейл":
                    {
                        // намери дали такъв User е регистриран с този имейл
                        // ползваме SingleOrDefault тъй като
                        // трябва да имаме само един User с такъв имейл
                        // ако не бъде намерен 1 такъв User, то ми върни NULL
                        // също така зареди ми Role полето на User-а с .Include() че да имам достъп до името на ролята на usera
                        var user = db.Users.Include(u => u.Role).SingleOrDefault(u => u.Email == searchTerm);
                        if (user != null)
                        {
                            // ако ролята е доктор
                            if (user.Role.Name.ToLower() == "doctor")
                            {
                                // намери информацията за доктора, който отговаря на съответния user
                                // използваме Single(), тъй като връзката ни е едно към едно
                                // и не би трябвало да има друг доктор с Id на намерения user
                                // всеки един доктор отговаря на точно един user - не по малко/ не повече

                                var doctor = db.Doctors.Single(d => d.UserId == user.Id);
                                foundDoctorsList.Add(doctor);
                            }
                            // ако ролята не му е доктор, не бива да го добавяме към списъка с намерени доктори
                        }
                        break;
                    }
                case "Първо име":
                    {
                        // ползваме .Where за да намерим колекция от доктори, които притежават това име
                        var doctors = db.Doctors.Where(d => d.FirstName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Презиме":
                    {
                        var doctors = db.Doctors.Where(d => d.MiddleName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Фамилия":
                    {
                        var doctors = db.Doctors.Where(d => d.LastName == searchTerm).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                case "Специалност":
                    {
                        // отново ползваме SingleOrDefault
                        // защото би трябвало да имаме не повече от 1 специалност с такова име в базата
                        // и защото ако не бъде намерена 1 специалност, то да ми върне NULL

                        var doctorSpeciality = db.DoctorSpecialities.SingleOrDefault(x => x.Name == searchTerm.ToUpper());
                        if (doctorSpeciality == null)
                        {
                            MessageBox.Show("Такава докторска специалност не съществува.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var doctors = db.Doctors.Include(d => d.DoctorSpeciality).Where(d => d.DoctorSpeciality.Name == searchTerm.ToUpper()).ToList();
                        if (doctors != null && doctors.Count != 0)
                        {
                            foundDoctorsList.AddRange(doctors);
                        }
                        break;
                    }
                default:
                    // тука даже не би трябвало да стигне програмата тъй като имаме
                    // само тези 5 неща в searchCriteriaListBox заредени
                    return;

            }

            if (foundDoctorsList.Count() == 0)
            {
                foundDoctorsListBox.Items.Clear();
                MessageBox.Show("Няма намерени доктори по този критерий.", "Не бяха намерени доктори.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foundDoctorsListBox.Items.Clear();

                foreach (var doctor in foundDoctorsList)
                {
                    // зареди ми имейла на User профила на намерения доктор
                    // ползваме Single() тъй като знаем че щом имаме намерени доктори
                    // всеки един от тях принадлежи само на един User профил
                    // нямаме един User профил, който да може да се използва от много доктори
                    // тъй като отново -> имаме връзка едно към едно
                    // един User съответства на един Doctor
                    // и е невъзможно един и същи User да отговаря на повече от един доктор
                    // заради дизайна на базата (foreign key-a към User-ите е UNIQUE, не може да се повтаря)
                    var user = db.Users.Single(x => x.Id == doctor.UserId);
                    foundDoctorsListBox.Items.Add(user.Email);
                }
                MessageBox.Show("Бяха намерени " + foundDoctorsList.Count() + " доктора.", "Има намерени доктори.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool CheckIfDoctorSelected()
        {
            if (foundDoctorsListBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
    }
}
