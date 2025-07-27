using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HRS.Controllers
{
    public class PatientController : Controller
    {
        private readonly IDoctorRepository IDoctorReposit;
        private readonly ISpecialtiesRepository ISpecialtiesReposit;
        public PatientController(IDoctorRepository IDoctorReposit, ISpecialtiesRepository iSpecialtiesReposit)
        {

            this.IDoctorReposit = IDoctorReposit;
            ISpecialtiesReposit = iSpecialtiesReposit;
        }
        public async Task<IActionResult> Index()
        {
            AppointmentModel appointmentModel = new AppointmentModel();
            var DoctorList = await IDoctorReposit.Get_Doctor();
            var SpecialtiesList = await ISpecialtiesReposit.Get_Specialties();
            var Doctor = DoctorList.Select(s => new DoctorModel
            {
                Id = s.Id,
                Name = s.Name,
                LK_Specialties = s.LK_Specialties,
            }).ToList();
            appointmentModel.Date = System.DateTime.Now;
            //appointmentModel.DoctorModel = Doctor;
            appointmentModel.LK_Specialties = SpecialtiesList;
            return View(appointmentModel);

        }
    }
}
