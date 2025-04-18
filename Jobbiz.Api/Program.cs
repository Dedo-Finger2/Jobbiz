using Microsoft.EntityFrameworkCore;
using Jobbiz.Api;

var builder = WebApplication.CreateBuilder(args);

// Adds the db context so the app can access it
builder.Services.AddDbContext<JobbizDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
