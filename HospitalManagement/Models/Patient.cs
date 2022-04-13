using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    [Index(nameof(EGN), IsUnique = true)] // правим Index на EGN-то и задаваме да не може да има две еднакви EGN-та/всички да са различни
    internal class Patient
    {
        public int Id { get; set; } // primary key
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }

        public int MedicalConditionId { get; set; } // foreign key
        public MedicalCondition MedicalCondition { get; set; } // foreign key navigational property
    }
}
