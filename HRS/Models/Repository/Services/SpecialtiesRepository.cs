using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRS.Models.Repository.Services
{
    public class SpecialtiesRepository: ISpecialtiesRepository
    {
        private readonly ApplicationdbContext context;

        public SpecialtiesRepository(ApplicationdbContext context)
        {
            this.context = context;
        }

        public async Task<List<LK_Specialties?>> Get_Specialties()
        {
            return await context.LK_Specialtie.Where(a => a.Status == true).ToListAsync();
        }
    }
}
