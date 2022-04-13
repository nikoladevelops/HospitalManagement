using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    [Index(nameof(Name), IsUnique = true)] // искаме имената на специалностите да не се повтарят
    public class DoctorSpeciality
    {
        public int Id { get; set; } // primary key
        public string Name { get; set; }
    }
}
