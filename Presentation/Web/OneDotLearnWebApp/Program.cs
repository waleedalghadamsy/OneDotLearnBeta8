using Microsoft.AspNetCore.Authentication.Cookies;
using OneDotLearnWebApp.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddRazorPages();

builder.Services.AddHttpClient();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(op =>
                {
                    op.LoginPath = new PathString("/Security/SignIn");
                    op.LogoutPath = new PathString("/Security/SignOut");
                    op.ExpireTimeSpan = new TimeSpan(0, 20, 0);
                });
builder.Services.AddAuthorization();

builder.Services.AddDistributedMemoryCache(); //For session state
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddSingleton<OneDotLearnWebHelper>();
builder.Services.AddSingleton<CoursesHelper>();
builder.Services.AddSingleton<CyclesHelper>();
builder.Services.AddSingleton<TraineesHelper>();
builder.Services.AddSingleton<EnrolmentsHelper>();
builder.Services.AddSingleton<FinancialsHelper>();
builder.Services.AddSingleton<SecurityHelper>();
builder.Services.AddSingleton<LoggerHelper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseCookiePolicy();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run($"http://*");
