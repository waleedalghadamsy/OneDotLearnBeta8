using AspFileLogTest.FileLogger;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureLogging((hostBldrCtxt, logging) =>
                    logging.AddOdlFileLogger(op => hostBldrCtxt.Configuration
                                                                    .GetSection("Logging")
                                                                    .GetSection("TestFileLogger")
                                                                    .GetSection("Options")
                                                                    .Bind(op)));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
