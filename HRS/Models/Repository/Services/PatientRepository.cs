using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HRS.Models.Repository.Services
{
    public class PatientRepository: IPatientRepository
    {
        private readonly ApplicationdbContext context;

        public PatientRepository(ApplicationdbContext context)
        {
            this.context = context;
        }
        public async Task<int> Add(Patient data)
        {
            int result = 0;
            try
            {
                var P = await context.Patient.Where(a => a.Mobile == data.Mobile.Trim()).SingleOrDefaultAsync();
                if (P != null)
                {
                    result = P.Id;
                }
                else
                {
                    var r = context.Patient.Add(data);
                    int add = await context.SaveChangesAsync();
                    if (add > 0)
                    {
                        result = data.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                
            }
            return result;
        }
    }
}
