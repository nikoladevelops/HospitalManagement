using Microsoft.EntityFrameworkCore;
namespace HospitalManagement.Models
{
    // наследяваме от Ef Core класа DbContext за да получим всичките свойства и методи
    internal class ApplicationDbContext:DbContext
    {
        // override-ваме базовата функционалност на този метод за да настроим EF Core от къде да чете/пише данни
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // задаваме на Ef Core да използва Sqlite Provider (че имаме локална база от данни) и пишем името на файла
            optionsBuilder.UseSqlite("Filename=HospitalData.db");

            // TODO add a migration InsertAllEntityModels
            // TODO implement MVVM pattern
            // TODO work on the login form functionality
        }

        // Таблиците в локалната ни база от данни се генерират благодарение на моделите,
        // които имаме в папката Models.
        // Чрез DbSet<EntityModel> TableName задаваме имена на таблиците в множествено число
        // докато е прието моделите ни да са в единствено число понеже са като Template
        // за всяко едно entity (модел User -> таблица Users и т.н)
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpeciality> DoctorSpecialities { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalCondition> MedicalConditions { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
       
    }
}
