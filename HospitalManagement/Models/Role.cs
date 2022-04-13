using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    [Index(nameof(Name), IsUnique = true)] // искаме имената на ролите да не се повтарят/ да са различни
    public class Role
    {
        public int Id { get; set; } // primary key
        public string Name { get; set; }
    }
}
