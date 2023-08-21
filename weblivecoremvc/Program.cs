using weblivecoremvc.wwwroot.Hubs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using weblivecoremvc.Data;
using weblivecoremvc.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("weblivecoremvcContextConnection") ?? throw new InvalidOperationException("Connection string 'weblivecoremvcContextConnection' not found.");

builder.Services.AddDbContext<weblivecoremvcContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<weblivecoremvcUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<weblivecoremvcContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapHub<UserHub>("/Hubs/usercount");
app.Run();
