using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using HRS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRS.Models.Repository.Services
{
    public class AppointmentRepositry: IAppointmentRepositry
    {
        private readonly ApplicationdbContext context;
        private readonly IPatientRepository IPatientReposit;
        public AppointmentRepositry(ApplicationdbContext context, IPatientRepository IPatientReposit)
        {
            this.context = context;
            this.IPatientReposit = IPatientReposit;
        }
        public async Task<int> Add(AppointmentModel data)
        {
            
            Appointment appointment = new Appointment
            {
                DoctorId = data.DoctorId,
                PatientID = data.PatientID,
                Date = data.Date,
                StartTime = data.StartTime,
                EndTime = data.EndTime,
            AddUser = data.AddUser,
            Status=true,
            CreatedDate = DateTime.Now


           };
            if (data.PatientID == 0)
            {
                Patient p = new Patient();
                p.Name = data.PatientName;
                p.Mobile = data.PatientMobile;
                p.CreateDate = DateTime.Now;
                appointment.PatientID=await IPatientReposit.Add(p);
            }
            context.Appointments.Add(appointment);
            await context.SaveChangesAsync();
            return appointment.Id;
        }
        public async Task<List<AppointmentModel?>> Get_Booking()
        {
            List<AppointmentModel> appointmentList = new List<AppointmentModel>();
            
            var Appointments = await context.Appointments.Include("Doctor").Include("Patients").Where(a => a.Status == true ).OrderByDescending(a => a.Id).ToListAsync();
            foreach (var data in Appointments)
            {
                var appointment = new AppointmentModel
                {
                    Id=data.Id,
                    PatientName = data.Patients.Name,
                    NameDoctor = data.Doctor.Name,
                    Date = data.Date,
                    StartTime = data.StartTime,

                };
                appointmentList.Add(appointment);
            }

            return appointmentList?.ToList();
        }

        public async Task<List<AppointmentModel?>> Get_AvaibleAppointment(DateTime date,int DoctorID)
        {
            List<AppointmentModel> appointmentList = new List<AppointmentModel>();
            int dayIndex = (int)date.DayOfWeek;
            var TimeOfDay = await context.DaysWork.Include("Doctor").Where(a => a.DayOfWeekNO == dayIndex && a.DoctorId == DoctorID).SingleOrDefaultAsync();
            if (TimeOfDay != null)
            {
                int durationService = 30;
                TimeOnly StartTime = TimeOfDay.StartTime;
                TimeOnly EndTime = TimeOfDay.EndTime;
                TimeSpan duration = EndTime - StartTime;
                int totalMinutes = (int)duration.TotalMinutes;
                int Count = totalMinutes / durationService;
               
                var existingAppointments = await context.Appointments
                .Where(a => a.DoctorId == DoctorID && a.Date == date)
                .ToListAsync();
                for (int i = 0; i < Count; i++)
                {
                    TimeOnly slotStart = StartTime.AddMinutes(i * durationService);
                    TimeOnly slotEnd = StartTime.AddMinutes((i + 1) * durationService);
                    bool isBooked = existingAppointments.Any(a =>a.StartTime == slotStart && a.EndTime == slotEnd);
                    if (!isBooked)
                    {
                        var appointment = new AppointmentModel
                        {
                            
                            DoctorId = DoctorID,
                            NameDoctor= TimeOfDay.Doctor.Name,
                            Date = date,
                            StartTime = StartTime.AddMinutes(i * durationService),
                            EndTime = StartTime.AddMinutes((i + 1) * durationService)

                        };
                        appointmentList.Add(appointment);
                    }
                }
            }
            return appointmentList?.ToList();
        }
    }
}
