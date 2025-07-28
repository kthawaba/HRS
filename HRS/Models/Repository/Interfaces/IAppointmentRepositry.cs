using HRS.Models.Entities;
using HRS.Models.ViewModels;

namespace HRS.Models.Repository.Interfaces
{
    public interface IAppointmentRepositry
    {
        Task<List<AppointmentModel>> Get_AvaibleAppointment(DateTime date,int DoctorID);
        Task<List<AppointmentModel>> Get_Booking();
        Task<int> Add(AppointmentModel data);
    }
}
