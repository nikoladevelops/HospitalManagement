using HospitalManagement.Forms.DoctorForms;
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

        private void createPatientMenuButton_Click(object sender, EventArgs e)
        {
            createPatientMenuButton.BackColor = activeButtonColor;
            searchPatientMenuButton.BackColor = notActiveButtonColor;
            medicalConditionsMenuButton.BackColor = notActiveButtonColor;
            OpenChildForm(new CreatePatientForm(db));
        }

        private void searchPatientMenuButton_Click(object sender, EventArgs e)
        {
            createPatientMenuButton.BackColor = notActiveButtonColor;
            searchPatientMenuButton.BackColor = activeButtonColor;
            medicalConditionsMenuButton.BackColor = notActiveButtonColor;
            var openChildFormMethod = (Form form) => OpenChildForm(form);
            OpenChildForm(new SearchPatientForm(db, openChildFormMethod));
        }

        private void medicalConditionsMenuButton_Click(object sender, EventArgs e)
        {
            createPatientMenuButton.BackColor = notActiveButtonColor;
            searchPatientMenuButton.BackColor = notActiveButtonColor;
            medicalConditionsMenuButton.BackColor = activeButtonColor;
            OpenChildForm(new MedicalConditionForm(db));
        }
    }
}
