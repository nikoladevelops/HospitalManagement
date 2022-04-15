using HospitalManagement.Forms.AdminForms;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Forms
{
    public partial class AdminPanelForm : Form
    {
        private ApplicationDbContext db;
        private Color activeButtonColor;
        private Color notActiveButtonColor;
        private Form activeForm;
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        public AdminPanelForm(User user):this()
        {
            this.db = new ApplicationDbContext();
            displayEmailLabel.Text = "Влезли сте като: " + user.Email;
            activeButtonColor = Color.FromArgb(0, 151, 230);
            notActiveButtonColor = Color.FromArgb(0, 168, 255);

            // това е default-ната форма която е отворена в началото
            createDoctorMenuButton.BackColor = activeButtonColor;
            OpenChildForm(new CreateDoctorForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            titleLabel.Text =childForm.Name;
            childForm.BringToFront();
            childForm.Show();

        }
        
        private void createDoctorMenuButton_Click(object sender, EventArgs e)
        {
            createDoctorMenuButton.BackColor = activeButtonColor;
            searchDoctorMenuButton.BackColor = notActiveButtonColor;
            createSpecialityMenuButton.BackColor = notActiveButtonColor;

            OpenChildForm(new CreateDoctorForm(db));
        }

        private void searchDoctorMenuButton_Click(object sender, EventArgs e)
        {
            searchDoctorMenuButton.BackColor = activeButtonColor;
            createDoctorMenuButton.BackColor = notActiveButtonColor;
            createSpecialityMenuButton.BackColor = notActiveButtonColor;

            OpenChildForm(new SearchDoctorForm(db));
        }

        private void createSpecialityMenuButton_Click(object sender, EventArgs e)
        {
            createSpecialityMenuButton.BackColor = activeButtonColor;
            searchDoctorMenuButton.BackColor = notActiveButtonColor;
            createDoctorMenuButton.BackColor = notActiveButtonColor;

            OpenChildForm(new CreateSpecialityForm(db));
        }
    }
}
