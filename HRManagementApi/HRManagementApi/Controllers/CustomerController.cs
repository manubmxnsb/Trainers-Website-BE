using AutoMapper;
using Azure;
using HRManagement.Business.Interface;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using HRManagement.DataAccess.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IDBService _dbService;
        private readonly IMapper _mapper;

        public CustomerController(IDBService dbService, IMapper mapper)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCustomer(int id, bool includeDocuments = false)
        //{
        //    var customer = await _dbService.GetCustomer(id, includeDocuments);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    if (includeDocuments)
        //    {
        //        return Ok(_mapper.Map<CustomerDto>(customer));
        //    }
        //    return (Ok(_mapper.Map<CustomerWithoutDocumentDto>(customer)));
        //}


        [HttpPut("{customerId}")]
        public async Task<ActionResult> EditCustomer(int customerId, CustomerForEditDto customerDto)
        {
            var customerEntity = _mapper.Map<Customer>(customerDto);

            if (customerEntity == null)
            {
                return NotFound();
            }

            //var customerEntity = new Customer();
            //customerEntity.Name = "Name";
            //customerEntity.Name = customerDto.Name;
            var customer = _mapper.Map<Customer>(customerDto);


            await _dbService.EditCustomer(customerEntity);
            return NoContent();
        }

        //edit customer partially

        //[HttpPatch("{customerId}")]

        //public async Task<ActionResult> PartiallyEditCustomer(
        //    int customerId, JsonPatchDocument<CustomerForEditDto> patchDocument)
        //{
        //    //if (!await _dbService.CustomerExists(customerId)) { return NotFound(); }

        //    var customerEntity = await _dbService
        //        .GetCustomerAsync(customerId, false);

        //    if (customerEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    var customerToPatch = _mapper.Map<CustomerForEditDto>(customerEntity);

        //    patchDocument.ApplyTo(customerToPatch, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (!TryValidateModel(customerToPatch))
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _mapper.Map(customerToPatch, customerEntity);

        //    //await _dbService.SaveChanges();

        //    return NoContent();


        //}
    }


}