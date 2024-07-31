using Ishkool.Repository.DataAccess;
using Ishkool.Repository.Repositories.Contracts;
using Ishkool.Repository.Repositories.Implementations;
using Ishkool.Service.Services.Contracts;
using Ishkool.Service.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSqlConnection"));
});


/* #####################   Repository Dependency Injection ######################## */

builder.Services.AddScoped<IStudentRepository, StudentRepository>();




/* #####################   Service Dependency Injection ######################## */

builder.Services.AddScoped<IStudentService, StudentService>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
