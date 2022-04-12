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
        }
    }
}
