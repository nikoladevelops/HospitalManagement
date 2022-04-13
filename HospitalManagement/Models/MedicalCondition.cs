using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    [Index(nameof(Name), IsUnique = true)] // искаме имената на заболяванята да не се повтарят
    public class MedicalCondition
    {
        public int Id { get; set; } // primary key
        public string Name { get; set; }
    }
}
