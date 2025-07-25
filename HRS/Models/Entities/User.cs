using System.Numerics;

namespace HRS.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
      
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public lK_UserType lK_UserType { get; set; }
        public ICollection<Appointment> Appointment { get; set; } = [];
        public ICollection<Doctor> Doctor { get; set; } = [];
    }
}
