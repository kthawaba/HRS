using HRS.Models.Entities;
using HRS.Models.ViewModels;

namespace HRS.Models.Repository.Interfaces
{
    public interface ISpecialtiesRepository
    {
        Task<List<LK_Specialties>> Get_Specialties();
        Task<int> Add(LK_SpecialtiesModel data);
    }
}
