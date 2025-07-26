using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRS.Models.Repository.Services
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly ApplicationdbContext context;

        public DoctorRepository(ApplicationdbContext context)
        {
            this.context = context;
        }

        public async Task<List<Doctor?>> Get_Doctor()
        {
            return await context.Doctor.Where(a => a.Status == true).ToListAsync();
        }
    }
}
