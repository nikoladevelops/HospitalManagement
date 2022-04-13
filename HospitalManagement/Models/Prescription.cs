namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; } // primary key
        public string PrescriptionText { get; set; } // съдържа имена на лекарства/дозировка и т.н
        public string DateCreated { get; set; } // тук за жалост не можем да използваме типа данни DateTime, тъй като локалната база Sqlite няма такъв тип

        public int PatientId { get; set; } // foreign key
        public Patient Patient { get; set; } // foreign key navigational property

        public int DoctorId { get; set; } // foreign key
        public Doctor Doctor { get; set; } // foreign key navigational property
    }
}
