using Microsoft.EntityFrameworkCore;
using OneDotLearnData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var conf = builder.Configuration;

builder.Services.AddDbContext<OdlDataContext>(op =>
        op.UseNpgsql(conf.GetConnectionString("OneDotLearnDB")));
builder.Services.AddDbContext<LoggingDataContext>(op =>
        op.UseNpgsql(conf.GetConnectionString("OneDotLearnLogDB")));

var depPort = conf.GetValue<string>("DeploymentPort");

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run($"http://*:{depPort}");
