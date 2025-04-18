using Microsoft.EntityFrameworkCore;
using Jobbiz.Api;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Adds the db context so the app can access it
builder.Services.AddDbContext<JobbizDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

var v1 = app.MapGroup("/api/v1");

v1.MapGet("/vacancies", async (JobbizDbContext db) =>
{
    try
    {
        return Results.Ok(await db.Vacancies.ToListAsync());
    } catch (Exception e)
    {
        Console.WriteLine(e);

        return Results.InternalServerError("try again later");
    }
});

app.Run();
