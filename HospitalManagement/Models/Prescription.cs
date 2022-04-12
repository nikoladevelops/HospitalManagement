namespace HospitalManagement.Models
{
    internal class Prescription
    {
        public int Id { get; set; }
        public string PrescriptionText { get; set; }
        public string DateCreated { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
