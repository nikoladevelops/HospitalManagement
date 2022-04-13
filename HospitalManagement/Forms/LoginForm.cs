using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Forms
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext db;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(ApplicationDbContext db):this() // преизползвай празния конструктор
        {
            this.db = db;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;

            User user = LoginUser(email,password);
            if (user != null) 
            {
                Form formToDisplay = null;
                switch (user.Role.Name.ToLower())
                {
                    case "admin":
                        formToDisplay= new AdminPanelForm(user);
                        break;
                    case "doctor":
                        formToDisplay = new DoctorPanelForm(user);
                        break;
                    default:
                        throw new ArgumentException("Това приложение не подържа други роли.");
                }

                this.Hide(); // скрий сегашната форма
                formToDisplay.Closed += (s, args) => this.Close(); // при затваряне на следваща форма затвори и тази (която е скрита вмомента)
                formToDisplay.Show(); // покажи новата форма
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
        private User LoginUser(string email, string password)
        {
            // тук използваме SingleOrDefault за да намерим от таблицата Users ЕДИНСТВЕНИЯ
            // user с такъв имейл и парола. Ако има повече от един user с такъв имейл
            // ще получим грешка / но това няма как да стане тъй като в самата база от данни
            // сме задали Email полето да е UNIQUE/ да няма еднакви имейли
            // Ако не бъде намерен един user с такъв имейл и парола ще бъде върнано NULL
            var user = db.Users
                .Include(u => u.Role) // зареди ми navigational property-то за ролите/ за да имам достъп до тях
                .SingleOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }
    }
}