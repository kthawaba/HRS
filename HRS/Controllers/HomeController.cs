using System.Diagnostics;
using HRS.Models;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository IUserReposit;
        private readonly ISpecialtiesRepository ISpecialtiesReposit;
        private readonly IDoctorRepository IDoctorReposit;
        public HomeController(ILogger<HomeController> logger, IUserRepository IUserReposit, ISpecialtiesRepository ISpecialtiesReposit, IDoctorRepository IDoctorReposit)
        {
            _logger = logger;
            this.IUserReposit = IUserReposit;
            this.ISpecialtiesReposit = ISpecialtiesReposit;
            this.IDoctorReposit = IDoctorReposit;
        }

        public async Task<IActionResult> Index()
        {
            
            var UserList = await IUserReposit.Get_AllUser();
            var SpecialtiesList = await ISpecialtiesReposit.Get_Specialties();
            var DoctorList = await IDoctorReposit.Get_Doctor();
            List<UserModel> List = new List<UserModel>();
            var Users = UserList.Select(s => new UserModel
            {
                Id = s.Id,
                Name = s.Name,
                UserName = s.UserName,
                UserTypeId = s.UserTypeId,
                Mobile = s.Mobile,
            }).ToList();
            UserModelData data = new UserModelData();
            data.UserModel = Users;
            data.LK_SpecialtiesModel = SpecialtiesList.ToList();
            data.DoctorsList = DoctorList.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
