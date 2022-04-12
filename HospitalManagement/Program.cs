using HospitalManagement.Forms;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement
{
    internal static class Program
    {
        // това е първият метод, който се изпълнява при стартиране на приложението
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // създаваме нова инстанция на нашия custom db context клас
            // при създаването на инстанция се изпълнява метода OnConfiguring(),
            // който сме настроили
            var dbContext = new ApplicationDbContext();

            // чрез .Migrate() казваме на Ef Core, ако не съществува такава база от данни
            // да бъде създадена нова, като бъдат изпълнени всички миграции на приложението в папката Migrations
            dbContext.Database.Migrate();
            Application.Run(new LoginForm());
        }
    }
}