using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

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
            return await context.Doctor.Include(d => d.LK_Specialties).Where(a => a.Status == true).ToListAsync();
        }
        public async Task<List<Doctor?>> Get_DoctorBySpecialtiesID(int SpecialtiesID)
        {
            return await context.Doctor.Where(a => a.Status == true&&a.LK_SpecialtiesID== SpecialtiesID).ToListAsync();
        }
        public async Task<int> Add(DoctorModel data)
        {
            var model = new Doctor();
            model.Name = data.Name;
            model.LK_SpecialtiesID = data.LK_SpecialtiesID;
            model.Status = true;
            model.AddUser = 1;
            model.CreatedDate = System.DateTime.Now;
            var r = context.Doctor.Add(model);
          int add=  await context.SaveChangesAsync();
            var selectedDays = data.DaysWork
         .Where(d => d.IsSelected)
         .Select(d => new DaysWork
         {
            DoctorId = add,
            DayOfWeekNO = d.DayOfWeekNO,
            DayOfWeekName = d.DayOfWeekName,
             StartTime = d.StartTime,  
             EndTime = d.EndTime,
         }).ToList();

            context.AddRange(selectedDays);
            await context.SaveChangesAsync();
            return add;
        }
    }
}
