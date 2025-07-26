using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
