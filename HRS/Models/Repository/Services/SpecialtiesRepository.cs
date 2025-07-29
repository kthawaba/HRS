using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
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
        public async Task<int> Add(LK_SpecialtiesModel data)
        {
            int result = 0;
            try
            {


                var model = new LK_Specialties();
                model.SpecialtyName = data.SpecialtyName;
                model.SpecialtyCode = data.SpecialtyCode;
                model.Description = data.Description;
                model.CreatedDate = System.DateTime.Now;
                model.Status = true;
                var r = context.LK_Specialtie.Add(model);
                int add = await context.SaveChangesAsync();
                if (add > 0)
                {
                    result= data.Id;
                }
                else
                {
                    throw new Exception("Failed to add specialty");
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }
    }
}
