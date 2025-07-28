using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HRS.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository IDoctorReposit;
        private readonly ISpecialtiesRepository ISpecialtiesReposit;
        public DoctorController(IDoctorRepository IDoctorReposit, ISpecialtiesRepository ISpecialtiesReposit)
        {

            this.IDoctorReposit = IDoctorReposit;
            this.ISpecialtiesReposit = ISpecialtiesReposit;
        }
        public async Task<IActionResult> Index()
        {

            var DoctorList = await IDoctorReposit.Get_Doctor();
            var Doctor = DoctorList.Select(s => new DoctorModel
            {
                Id = s.Id,
                Name = s.Name,
                LK_Specialties = s.LK_Specialties,
            }).ToList();
            return View(Doctor);
        }
        public async Task<IActionResult> Get_DoctorBySpecialtiesID(int SpecialtiesID)
        {
           
          
            var doctors = await IDoctorReposit.Get_DoctorBySpecialtiesID(SpecialtiesID);
            return Json(doctors);


        }
        [HttpPost]
        public async Task<IActionResult> Add(DoctorModel date)
        {
            if (date.DaysWork == null || !date.DaysWork.Any(d => d.IsSelected))
            {
                ModelState.AddModelError("DaysWork", "Please select at least one day.");

                date.LK_SpecialtiesList = await ISpecialtiesReposit.Get_Specialties();

                return View("~/Views/Admin/AddNewDoctor.cshtml", date);
            }
            User us= JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("UserData")!)!;
            date.AddUser = us.Id;
            int add = await IDoctorReposit.Add(date);
            if (add > 0)
            {
                TempData["SuccessMessage"] = "Doctor added successfully.";
                ModelState.AddModelError("Doctor", "Doctor added successfully.");
            }
            else
            {
                ModelState.AddModelError("Doctor", "Failed to add doctor. Please try again.");
                date.LK_SpecialtiesList = await ISpecialtiesReposit.Get_Specialties();

                return View("~/Views/Admin/AddNewDoctor.cshtml", date);
            }

               
                return RedirectToAction("Index", "Admin");
        }
        public List<(int Index, string DayName)> GetDaysOfWeek()
        {
            var days = new List<(int, string)>
    {
        (0, "Sunday"),
        (1, "Monday"),
        (2, "Tuesday"),
        (3, "Wednesday"),
        (4, "Thursday"),
        (5, "Friday"),
        (6, "Saturday")
    };

            return days;
        }
    }
}
