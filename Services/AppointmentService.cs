using SalesManagment.Entities;
using SalesManagment.Models;
using SalesManagment.Services.Contracts;
using SalesManagment.Extensions;
using SalesManagment.Data;
using SalesManagment.Pages;
using Microsoft.AspNetCore.Components.Authorization;

namespace SalesManagment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly AuthenticationStateProvider asp;

        public AppointmentService(ApplicationDbContext applicationDbContext, AuthenticationStateProvider asp)
        {
            this.applicationDbContext = applicationDbContext;
            this.asp = asp;
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

        public async Task DeleteAppointment(int id)
        {
            try
            {
                Appointment? _appointment = await this.applicationDbContext.Appointments.FindAsync(id);
                if (_appointment != null)
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
                var emp = await GetLoggedOnEmployee();
                return await this.applicationDbContext.Appointments.Where(e => e.EmployeeId == emp.Id).Convert();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAppointment(AppointmentModel appointmentMod)
        {
            try
            {
                Appointment appointment = await this.applicationDbContext.Appointments.FindAsync(appointmentMod.Id);
                if (appointment != null)
                {
                    appointment.Description = appointmentMod.Description;
                    appointment.IsAllDay= appointmentMod.IsAllDay;
                    appointment.RecurrenceId= appointmentMod.RecurrenceId;
                    appointment.RecurrenceRule = appointmentMod.RecurrenceRule;
                    appointment.RecurrenceException= appointmentMod.RecurrenceException;
                    appointment.StartTime = appointmentMod.StartTime;
                    appointment.EndTime = appointmentMod.EndTime;
                    appointment.Subject = appointmentMod.Subject;
                    appointment.Location= appointmentMod.Location;

                    await this.applicationDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task<Employee> GetLoggedOnEmployee()
        {
            var authState = await this.asp.GetAuthenticationStateAsync();
            var user = authState.User;

            return await user.GetEmployeeObject(this.applicationDbContext);
        }
    }
}
