namespace HospitalManagement.Models
{
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
