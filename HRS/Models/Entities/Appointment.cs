namespace HRS.Models.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public int AddUser { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }


        public Doctor Doctor { get; set; }
        public Patient Patients { get; set; }

        
    }
}
