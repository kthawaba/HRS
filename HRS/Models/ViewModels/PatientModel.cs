using HRS.Models.Entities;

namespace HRS.Models.ViewModels
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Doctor> Doctor { get; set; }
    }
}
