namespace HospitalManagement.Models
{
    internal class Doctor
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int DoctorSpecialityId { get; set; }
        public DoctorSpeciality DoctorSpeciality { get; set; }
    }
}
