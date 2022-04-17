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

            // Тъй като искаме винаги да изпълняваме метода OpenChildForm за всяка една нова отворена форма,
            // а нямаме достъп до този метод вътре в друг клас, ползваме функционално програмиране
            // за да предадем този метод като параметър на конструктора на класа, който се нуждае от него
            // в нашия случай имаме класа SearchDoctorForm, който ТРЯБВА ДА МОЖЕ да отваря форми
            // затова му предоставяме метода OpenChildForm като параметър
            
            // създаваме си нов Action който като параметър приема инстанция на Form класа
            // и изпълнява метода в този клас OpenChildForm
            // след това просто даваме този Action<Form> като параметър при създаването на
            // инстанция на SearchDoctorForm
            // и вече SearchDoctorForm може да изпълнява форми както този клас
            var openChildFormMethod = (Form form) => OpenChildForm(form);
            var searchDoctorForm = new SearchDoctorForm(db, openChildFormMethod);
            OpenChildForm(searchDoctorForm);
        }

        private void createSpecialityMenuButton_Click(object sender, EventArgs e)
        {
            createSpecialityMenuButton.BackColor = activeButtonColor;
            searchDoctorMenuButton.BackColor = notActiveButtonColor;
            createDoctorMenuButton.BackColor = notActiveButtonColor;

            OpenChildForm(new DoctorSpecialityForm(db));
        }
    }
}
