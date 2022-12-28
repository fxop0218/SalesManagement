using SalesManagment.Entities;
using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentModel>> GetAppointments();
        Task DeleteAppointment(int appointmentId);
        Task UpdateAppointment(AppointmentModel appointment);
        Task AddApointment(AppointmentModel appointment);
    }
}
