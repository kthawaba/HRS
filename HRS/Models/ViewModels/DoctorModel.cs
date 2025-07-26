using HRS.Models.Entities;

namespace HRS.Models.ViewModels
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LK_SpecialtiesID { get; set; }
        public int AddUser { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public LK_Specialties LK_Specialties { get; set; }

        public List<Appointment> Appointments { get; set; }
        public List<DaysWork> DaysWork { get; set; }
    }
}
