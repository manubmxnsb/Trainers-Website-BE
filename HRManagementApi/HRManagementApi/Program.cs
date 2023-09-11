using AutoMapper;
using HRManagement.DataAccess.DbContexts;
using HRManagementApi.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});

builder.Services.AddScoped<HRManagement.DataAccess.Repositories.IDBRepository, HRManagement.DataAccess.Repositories.DBRepository>();
builder.Services.AddScoped<HRManagement.Business.Services.IBusinessLayer, HRManagement.Business.Services.BusinessLayer>();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementAPI.db"]));

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CustomerProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddMvc();

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
