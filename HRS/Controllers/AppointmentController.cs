using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HRS.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepositry IAppointmentReposit;
        
        public AppointmentController(IAppointmentRepositry IAppointmentReposit)
        {

            this.IAppointmentReposit = IAppointmentReposit;
            
        }
        [HttpGet]
        public async Task<IActionResult> Search(int doctorId,DateTime date)
        {
           var result = await  IAppointmentReposit.Get_AvaibleAppointment(date, doctorId);
            return Json(new { success = true, data = result });

        }
        [HttpPost]
        public async Task<IActionResult> Add(int doctorId,string patientName,string patientMobile,TimeOnly startTime,TimeOnly endTime,DateTime appointmentDate)
        {
          
            AppointmentModel date = new AppointmentModel();
            date.DoctorId = doctorId;
            date.PatientName = patientName;
            date.PatientMobile = patientMobile;
            date.StartTime = startTime;
            date.EndTime = endTime;
            date.Date = appointmentDate;
            User us = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("UserData"));
            date.AddUser = us.Id;
            int add = await IAppointmentReposit.Add(date);
            return RedirectToAction("Index", "Admin");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
