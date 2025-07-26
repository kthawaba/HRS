using HRS.Models.Entities;

namespace HRS.Models.ViewModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }

        public bool Status { get; set; }
        public int UserTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Doctor> Doctor { get; set; } = [];
    }
    public class UserModelData
    {
        public List<UserModel> UserModel { get; set; } = [];
        public List<LK_Specialties> LK_SpecialtiesModel { get; set; } = [];
        public List<Doctor> DoctorsList { get; set; } = [];
         

    }
}
