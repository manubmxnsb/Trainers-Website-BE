using HRManagement.Business.Profiles;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Profiles;
using HRManagement.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HRManagementDBContext>(dbContextOptions => dbContextOptions.UseSqlServer(
    builder.Configuration["ConnectionStrings:DBConnectionString"]));

builder.Services.AddScoped<ICustomerInfoRepository, CustomerInfoRepository>();

builder.Services.AddAutoMapper(typeof(CustomerProfile), typeof(DocumentProfile));

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true; //Returns not acceptable for unsuported actions
}).AddXmlDataContractSerializerFormatters();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
