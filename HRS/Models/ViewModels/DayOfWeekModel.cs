using HRS.Models.Entities;

namespace HRS.Models.ViewModels
{
    public class DayOfWeekModel
    {
        public int Id { get; set; }
        public int DayOfWeekNO { get; set; }
        public string DayOfWeekName { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int Duration { get; set; }
        public int DoctorId { get; set; }
        public bool IsSelected { get; set; }
        public int AddUser { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public Doctor Doctor { get; set; }
    }
}
