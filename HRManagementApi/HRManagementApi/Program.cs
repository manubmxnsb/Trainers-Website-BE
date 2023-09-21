using HRManagement.Business.Profiles;
using HRManagement.Business.Services;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Repositories;
using HRManagementApi.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:HRManagementDatabase"]));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();


builder.Services.AddAutoMapper(typeof(CustomerProfile), typeof(DocumentProfile));

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
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
