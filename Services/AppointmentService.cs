using SalesManagment.Entities;
using SalesManagment.Models;
using SalesManagment.Services.Contracts;
using SalesManagment.Extensions;
using SalesManagment.Data;
using SalesManagment.Pages;

namespace SalesManagment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public AppointmentService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext; 
        }
        public async Task AddAppointment(AppointmentModel appointment)
        {
            try
            {
                Appointment _appointment = appointment.Convert(); 
                await this.applicationDbContext.AddAsync(_appointment);
                await this.applicationDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAppointment(int appointmentId)
        {
            try
            {
                Appointment? _appointment = await this.applicationDbContext.Appointments.FindAsync(appointmentId);
                if (_appointment == null)
                {
                    this.applicationDbContext.Remove(_appointment);
                    await this.applicationDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<AppointmentModel>> GetAppointments()
        {
            try
            {
                return await this.applicationDbContext.Appointments.Where(e => e.EmployeeId == 9).Convert();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAppointment(AppointmentModel appointment)
        {
            try
            {
                Appointment? _appointment = await this.applicationDbContext.Appointments.FindAsync(appointment.Id);
                if (_appointment == null)
                {
                    _appointment.Description = appointment.Description;
                    _appointment.IsAllDay= appointment.IsAllDay;
                    _appointment.RecurrenceId= appointment.RecurrenceId;
                    _appointment.RecurrenceRule = appointment.RecurrenceRule;
                    _appointment.RecurrenceException= appointment.RecurrenceException;
                    _appointment.StartTime = appointment.StartTime;
                    _appointment.EndTime = appointment.EndTime;
                    _appointment.Subject = appointment.Subject;
                    _appointment.Location= appointment.Location;

                    await this.applicationDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
