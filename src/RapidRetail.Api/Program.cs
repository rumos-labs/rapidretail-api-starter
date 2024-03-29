using Microsoft.EntityFrameworkCore;
using RapidRetail.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RapidRetailDbContext>(options =>
{
    options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=RapidRetail;Integrated Security=sspi;");
    //options.UseSqlServer("Data Source=rapidretail-db.rumos.cloud;Database=RapidRetail;User Id=sa;Password=rumos123!;TrustServerCertificate=true;");
});

// TODO: Register services here

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();