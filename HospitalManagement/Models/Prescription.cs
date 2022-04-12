namespace HospitalManagement.Models
{
    internal class Prescription
    {
        public int Id { get; set; } // primary key
        public string PrescriptionText { get; set; }
        public string DateCreated { get; set; } // тук за жалост не можем да използваме типа данни DateTime, тъй като локалната база Sqlite няма такъв тип

        public int PatientId { get; set; } // foreign key
        public Patient Patient { get; set; } // foreign key navigational property

        public int DoctorId { get; set; } // foreign key
        public Doctor Doctor { get; set; } // foreign key navigational property
    }
}
