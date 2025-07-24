namespace HRS.Models.Entities
{
    public class DaysWork
    {
        public int Id { get; set; }
        public int DayOfWeekNO { get; set; }
        public int DayOfWeekName { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int Duration { get; set; }
        public int DoctorId { get; set; }
        public int AddUser { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public Doctor Doctor { get; set; }

      
    }
}
