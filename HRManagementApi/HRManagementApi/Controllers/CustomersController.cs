using AutoMapper;
using Azure;
using HRManagement.Business.Interface;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _dbService;

        public CustomersController(ICustomerService dbService, IMapper mapper)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }


        [HttpPut("customerEdit")]

        public async Task<ActionResult> EditCustomer(
            CustomerDto customerToUpdate)
        {
           
            await _dbService.EditCustomer(customerToUpdate);

            return NoContent();


        }
    }
  
}