using HRManagement.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HRManagement.DataAccess.Repositories.IDBRepository, HRManagement.DataAccess.Repositories.DBRepository>();
builder.Services.AddScoped<HRManagement.Business.Services.IBusinessService, HRManagement.Business.Services.BusinessService>();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementAPI.db"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
