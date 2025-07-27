using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDoctorRepository IDoctorReposit;
        private readonly ISpecialtiesRepository ISpecialtiesReposit;
        public AdminController(IDoctorRepository IDoctorReposit, ISpecialtiesRepository ISpecialtiesReposit)
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
        public async Task<IActionResult>  AddNewDoctor()
        {
            var SpecialtiesList = await ISpecialtiesReposit.Get_Specialties();
            DoctorModel data = new DoctorModel();
            data.LK_SpecialtiesList = SpecialtiesList;
            var Days = GetDaysOfWeek();
            var List = Days.Select(s => new DayOfWeekModel
            {
                DayOfWeekNO=s.Index,
                DayOfWeekName=s.DayName,

            }).ToList();
            data.DaysWork = List;
            return View(data);
             
            
        }
        public List<(int Index, string DayName)> GetDaysOfWeek()
        {
            var days = new List<(int , string)>
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
