using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    [Index(nameof(Email), IsUnique = true)] // правим Index на имейла и задаваме да не може да има два еднакви имейла/всички да са различни
    internal class User
    {
        public int Id { get; set; } // primary key
        public string Email { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; } // foreign key
        public Role Role { get; set; } // foreign key navigational property - то ни трябва за да може EF Core да разбере RoleId полето към коя таблица/модел сочи
    }
}
