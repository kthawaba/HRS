using HRS.Models.Entities;
using HRS.Models.ViewModels;

namespace HRS.Models.Repository.Interfaces
{
    public interface IPatientRepository
    {
        Task<int> Add(Patient data);
    }
}
