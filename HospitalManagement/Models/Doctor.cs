namespace HospitalManagement.Models
{
    internal class Doctor
    {
        public int Id { get; set; } // primary key

        public int UserId { get; set; } // foreign key
        public User User { get; set; } // foreign key navigational property

        public int DoctorSpecialityId { get; set; } // foreign key
        public DoctorSpeciality DoctorSpeciality { get; set; } // foreign key navigational property
    }
}
