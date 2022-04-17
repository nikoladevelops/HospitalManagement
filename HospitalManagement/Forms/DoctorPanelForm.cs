using HospitalManagement.Forms.AdminForms;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Forms
{
    public partial class DoctorPanelForm : Form
    {
        private ApplicationDbContext db;
        private Color activeButtonColor;
        private Color notActiveButtonColor;
        private Form activeForm;
        public DoctorPanelForm()
        {
            InitializeComponent();
        }
        public DoctorPanelForm(User user):this()
        {
            this.db = new ApplicationDbContext();
            activeButtonColor = Color.FromArgb(0, 151, 230);
            notActiveButtonColor = Color.FromArgb(0, 168, 255);

            // това е default-ната форма която е отворена в началото
            MakeFormActive(new HomeForm(user.Email, user.Role.Name));
        }

        private void OpenChildForm(Form childForm)
        {
            if (childForm.Text == activeForm.Text)
            {
                // ако искаме отново да отворим същата форма, няма нужда да я презареждаме.
                return;
            }

            // затвори предишната форма
            if (activeForm != null)
            {
                activeForm.Close();
            }
            // направи новата форма да е активна
            MakeFormActive(childForm);
        }

        private void MakeFormActive(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            titleLabel.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void createDoctorMenuButton_Click(object sender, EventArgs e)
        {
            createPatientMenuButton.BackColor = activeButtonColor;
            searchPatientMenuButton.BackColor = notActiveButtonColor;
            createPrescriptionMenuButton.BackColor = notActiveButtonColor;

            //OpenChildForm(new CreateDoctorForm(db));
        }

        private void searchDoctorMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void createSpecialityMenuButton_Click(object sender, EventArgs e)
        {
            createPrescriptionMenuButton.BackColor = activeButtonColor;
            searchPatientMenuButton.BackColor = notActiveButtonColor;
            createPatientMenuButton.BackColor = notActiveButtonColor;

            //OpenChildForm(new DoctorSpecialityForm(db));
        }
    }
}
