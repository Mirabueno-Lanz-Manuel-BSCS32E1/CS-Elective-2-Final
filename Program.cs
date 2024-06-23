using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AttendanceMonitoring.Repository;
using AttendanceMonitoring.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register AttendanceMonitoring services and repositories
builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>();
builder.Services.AddScoped<AttendanceService>();

// Register Onboarding and Offboarding services and repositories
builder.Services.AddScoped<IOnboardingOffboardingRepository, OnboardingOffboardingRepository>();
builder.Services.AddScoped<OnboardingOffboardingService>();

// Register Payroll services and repositories
builder.Services.AddScoped<IPayrollRepository, PayrollRepository>();
builder.Services.AddScoped<PayrollService>();

// Register Compensation and Benefits services and repositories
builder.Services.AddScoped<ICompensationRepository, CompensationRepository>();
builder.Services.AddScoped<IBenefitsRepository, BenefitsRepository>();
builder.Services.AddScoped<CompensationBenefitsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
