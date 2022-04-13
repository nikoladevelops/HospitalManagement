namespace HospitalManagement.Models
{
    internal class Doctor
    {
        public int Id { get; set; } // primary key
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int UserId { get; set; } // foreign key
        public User User { get; set; } // foreign key navigational property

        public int DoctorSpecialityId { get; set; } // foreign key
        public DoctorSpeciality DoctorSpeciality { get; set; } // foreign key navigational property
    }
}
