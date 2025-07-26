using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository IDoctorReposit;
        public DoctorController(IDoctorRepository IDoctorReposit)
        {
            
            this.IDoctorReposit = IDoctorReposit;
        }
        public async Task<IActionResult> Index()
        {
          
            var DoctorList = await IDoctorReposit.Get_Doctor();
            var Doctor = DoctorList.Select(s => new DoctorModel
            {
                Id = s.Id,
                Name = s.Name,
                LK_Specialties=s.LK_Specialties,
            }).ToList();
            return View(Doctor);
        }
    }
}
