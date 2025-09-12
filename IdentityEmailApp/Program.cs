using IdentityEmailApp.Context;
using IdentityEmailApp.Entities;
using IdentityEmailApp.Validations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));

});

builder.Services.AddIdentity<AppUser, AppRole>(config =>
{
    config.User.RequireUniqueEmail = true;

})
.AddEntityFrameworkStores<AppDbContext>()
.AddErrorDescriber<CustomErrorDescriber>();




builder.Services.AddControllersWithViews();
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.Cookie.Name = "IdentityCookie";
    opt.LoginPath = "/Login/Index";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Message}/{action=SendMessage}/{id?}")
    .WithStaticAssets();


app.Run();
