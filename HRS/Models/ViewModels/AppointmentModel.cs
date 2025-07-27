using HRS.Models.Entities;

namespace HRS.Models.ViewModels
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DoctorId { get; set; }
        public int LK_SpecialtiesID { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }



        public List<LK_Specialties> LK_Specialties { get; set; } = [];
        public List<DoctorModel> DoctorModel { get; set; }
       

    }
}
