using AutoMapper;
using HRManagement.Business.Profiles;
using HRManagement.Business.Services;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Profiles;
using HRManagement.DataAccess.Repositories;
using HRManagementApi.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementDataBase"]));

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CustomerProfile());
    mc.AddProfile(new DocumentProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddMvc();
builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementDB"]));


builder.Services.AddAutoMapper(typeof(CustomerProfile), typeof(DocumentProfile));

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.ConfigureExceptionMiddleware();

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
