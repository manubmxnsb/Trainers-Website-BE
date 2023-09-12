using AutoMapper;
using HRManagement.Business.IServices;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.IRepositories;
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

builder.Services.AddScoped<ICustomerRepository, HRManagement.DataAccess.Repositories.CustomerRepository>();
builder.Services.AddScoped<IDocumentRepository, HRManagement.DataAccess.Repositories.DocumentRepository>();
builder.Services.AddScoped<ICustomerService, HRManagement.Business.Services.CustomerService>();
builder.Services.AddScoped<IDocumentService, HRManagement.Business.Services.DocumentService>();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementDB"]));

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CustomerProfile());
    mc.AddProfile(new DocumentProfile());
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
