using SignlRChat.Hubs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SignlRChat.Data;
using SignlRChat.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SignlRChatContextConnection") ?? throw new InvalidOperationException("Connection string 'SignlRChatContextConnection' not found.");

builder.Services.AddDbContext<SignlRChatContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SignlRChatUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SignlRChatContext>();



builder.Services.AddRazorPages();
builder.Services.AddSignalR();
//builder.Services.AddScoped<videoService>();
//builder.Services.AddHostedService<Worker>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.MapHub<ChatHub>("/chatHub");

//app.MapHub<NotificationHub>("/NotificationHub");


app.Run();
