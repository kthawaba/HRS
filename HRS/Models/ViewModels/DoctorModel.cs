using HRS.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace HRS.Models.ViewModels
{
    public class DoctorModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Specialties is required")]
        public int LK_SpecialtiesID { get; set; }
        public int AddUser { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public LK_Specialties LK_Specialties { get; set; }

        public List<Appointment> Appointments { get; set; }
        public List<DayOfWeekModel> DaysWork { get; set; }
        public List<LK_Specialties> LK_SpecialtiesList { get; set; }
    }
}
