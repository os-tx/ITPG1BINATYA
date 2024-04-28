using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Phar.Data;
using Phar.Models.Domain;

var builder = WebApplication.CreateBuilder(args);


//var connectionString = builder.Configuration.GetConnectionString()

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer());

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContextConnection")));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
    AddCookie(option => { option.LoginPath = "/Home/Login"; option.ExpireTimeSpan = TimeSpan.FromMinutes(20); });

//var connectionString = builder.Configuration.GetConnectionString("PharDbContextConnection") ?? throw new InvalidOperationException("Connection string 'PharDbContextConnection' not found.");



//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<IdentityUser>().AddDefaultTokenProviders()
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();





// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Signup}/{action=log}/{id?}");

app.MapRazorPages();

app.Run();
