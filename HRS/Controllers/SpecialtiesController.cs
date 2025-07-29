using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class SpecialtiesController : Controller
    {

        private readonly ISpecialtiesRepository ISpecialtiesReposit;
        public SpecialtiesController(ISpecialtiesRepository ISpecialtiesReposit)
        {


            this.ISpecialtiesReposit = ISpecialtiesReposit;
        }
        [HttpPost]
        public async Task<IActionResult> Add(string SpecialtyName, string SpecialtyCode, string Description)
        {

            LK_SpecialtiesModel data = new LK_SpecialtiesModel();
            data.SpecialtyName = SpecialtyName;
            data.SpecialtyCode = SpecialtyCode;
            data.Description = Description;
            int add = await ISpecialtiesReposit.Add(data);
            if (add < 0)
            {
                ModelState.AddModelError("Specialties", "Failed to add specialty.");
            }
            
            return RedirectToAction("SpecialtiesManage", "Admin");
        }
    }
}
