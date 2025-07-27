using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class AddNewDoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewDoctor()
        {
            return View();
        }
    }
}
