using BugReport.Repository.interfaces;
using BugReport.Repository.user;
using BugReport.Service;
using BugReport.Service.authorization;
using BugReport.Service.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserRepository, EFCoreUserRepository>();
builder.Services.AddScoped<AuthorizationManager>();
builder.Services.AddScoped<IUserManagementService, UserManagementService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
