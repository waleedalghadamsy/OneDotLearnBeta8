using Microsoft.EntityFrameworkCore;
using OneDotLearnData;
using OneDotLearnData.EntitiesRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var conf = builder.Configuration;

builder.Services.AddDbContextFactory<OdlDataContext>(op =>
        op.UseNpgsql(conf.GetConnectionString("OneDotLearnDB")));
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run("http://*:27727");
