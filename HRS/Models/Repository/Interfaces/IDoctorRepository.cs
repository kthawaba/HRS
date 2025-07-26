using HRS.Models.Entities;

namespace HRS.Models.Repository.Interfaces
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> Get_Doctor();
    }
}
