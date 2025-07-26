using HRS.Models.Entities;

namespace HRS.Models.Repository.Interfaces
{
    public interface ISpecialtiesRepository
    {
        Task<List<LK_Specialties>> Get_Specialties();
    }
}
