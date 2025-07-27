using HRS.Models.Entities;
using HRS.Models.ViewModels;

namespace HRS.Models.Repository.Interfaces
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> Get_Doctor();
        Task<int> Add(DoctorModel data);
        Task <List<Doctor>> Get_DoctorBySpecialtiesID(int SpecialtiesID);
    }
}
