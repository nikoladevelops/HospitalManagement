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
            SeedDatabase();
            
            Application.Run(new LoginForm(new ApplicationDbContext()));
        }

        private async static void SeedDatabase()
        {
            // създаваме нова инстанция на нашия custom db context клас
            // при създаването на инстанция се изпълнява метода OnConfiguring(),
            // който сме настроили
            using (var db = new ApplicationDbContext())
            {
                // чрез .Migrate() казваме на Ef Core, ако не съществува такава база от данни
                // да бъде създадена нова, като бъдат изпълнени всички миграции на приложението в папката Migrations
                await db.Database.MigrateAsync();

                if (db.Roles.Count() < 2) // ако имаме по-малко от две роли, значи таблицата ни е празна
                {
                    // създаване на ролите в приложението / НА АНГЛИЙСКИ
                    var adminRole = new Role();
                    adminRole.Name = "admin";

                    var doctorRole = new Role();
                    doctorRole.Name = "doctor";

                    var savedAdminRole = await db.Roles.AddAsync(adminRole);
                    var savedDoctorRole = await db.Roles.AddAsync(doctorRole);
                    await db.SaveChangesAsync();

                    // създаване на специалностите на докторите ВИНАГИ С ГЛАВНИ БУКВИ
                    var doctorSpeciality1 = new DoctorSpeciality();
                    doctorSpeciality1.Name = "УШЕН ЛЕКАР";

                    var doctorSpeciality2 = new DoctorSpeciality();
                    doctorSpeciality2.Name = "ОЧЕН ЛЕКАР";

                    var doctorSpeciality3 = new DoctorSpeciality();
                    doctorSpeciality3.Name = "ХИРУРГ";

                    var doctorSpeciality4 = new DoctorSpeciality();
                    doctorSpeciality4.Name = "СПОРТНА МЕДИЦИНА";

                    await db.DoctorSpecialities.AddAsync(doctorSpeciality1);
                    await db.DoctorSpecialities.AddAsync(doctorSpeciality2);
                    await db.DoctorSpecialities.AddAsync(doctorSpeciality3);
                    var doctorSpeciality = await db.DoctorSpecialities.AddAsync(doctorSpeciality4); // запаметяваме тази специалност в променлива за да я използваме при създаването на доктор
                    
                    await db.SaveChangesAsync();

                    // създаване по един акаунт от всяка роля (Admin и Doctor)
                    var adminUser = new User();
                    adminUser.RoleId = savedAdminRole.Entity.Id;
                    adminUser.Email = "admin@gmail.com";
                    adminUser.Password = "admin123";

                    await db.Users.AddAsync(adminUser);

                    var doctorUser = new User();
                    doctorUser.RoleId = savedDoctorRole.Entity.Id;
                    doctorUser.Email = "doctor@gmail.com";
                    doctorUser.Password = "doctor123";

                    await db.SaveChangesAsync();

                    // запаметяваме в променлива doctor user-a за да може
                    // като създадем доктор, да кажем данните на доктора на кой
                    // user account съответства
                    var addedDoctorUser = await db.Users.AddAsync(doctorUser);

                    await db.SaveChangesAsync();

                    // създаване на доктор
                    var doctor = new Doctor()
                    {
                        FirstName = "Борис",
                        MiddleName = "Христов",
                        LastName = "Николов",
                        UserId = addedDoctorUser.Entity.Id, // id-то на user-a който ще съответства на тази информация
                        DoctorSpecialityId = doctorSpeciality.Entity.Id, // id-то на специалността на този доктор
                    };

                    await db.Doctors.AddAsync(doctor);

                    await db.SaveChangesAsync();

                    // създаване на заболяване
                    var medicalCondition = new MedicalCondition()
                    {
                        Name = "Деменция"
                    };

                    // запаметяване на добавеното заболяване в променлива
                    var addedMedicalCondition = await db.MedicalConditions.AddAsync(medicalCondition);
                    await db.SaveChangesAsync();

                    var patient = new Patient()
                    {
                        FirstName = "Йордан",
                        MiddleName = "Бобов",
                        LastName = "Мартинов",
                        EGN = "4369283746",
                        MedicalConditionId = addedMedicalCondition.Entity.Id // id-то на заболяването на този пациент
                    };
                    await db.Patients.AddAsync(patient);

                    await db.SaveChangesAsync();
                }
            }
        }
    }
}