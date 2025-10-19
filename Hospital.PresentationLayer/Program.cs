
using Hospital.BLL.Service.ClinicService;
using Hospital.BLL.Service.DoctorService;
using Hospital.BLL.Service.EmployeeService;
using Hospital.BLL.Service.PatientService;
using Hospital.BLL.Service.ReservationService;
using Hospital.DAL.Context;
using Hospital.DAL.Repo.ClinicRepo;
using Hospital.DAL.Repo.DoctorRepo;
using Hospital.DAL.Repo.EmployeeRepo;
using Hospital.DAL.Repo.PatientRepo;
using Hospital.DAL.Repo.Reservation;
using Hospital.DAL.Repo.Reservations;
using Microsoft.EntityFrameworkCore;

namespace Hospital.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
                       opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IReservationRepo, ReservationRepo>();
            builder.Services.AddScoped<IPatientRepo, PatientRepo>();
            builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
            builder.Services.AddScoped<IClinicRepo, ClinicRepo>();

            builder.Services.AddScoped<IReservationService, ReservationService>();
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IDoctorService, DoctorService>();
            builder.Services.AddScoped<IClinicService, ClinicService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
