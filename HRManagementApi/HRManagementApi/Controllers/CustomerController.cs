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




        [HttpPut("{id}")]

        public async Task<ActionResult> EditCustomer(long id,
            CustomerForEditDto customerToUpdate)
        {
            if (!await _dbService.CustomerExistsAsync(id))
            {
                return NotFound();
            }

            await _dbService.EditCustomer(id, customerToUpdate);

            await _dbService.SaveChangesAsync();

            return NoContent();


        }
    }

        //edit customer partially

        //    [HttpPatch("{id}")]

        //    public async Task<ActionResult> PartiallyEditCustomer(
        //        int id, JsonPatchDocument<CustomerForEditDto> patchDocument)
        //    {
        //        if (!await _repository.CustomerExistsAsync(id)) { return NotFound(); }

        //        var customerEntity = await _repository
        //            .GetCustomerAsync(id, false);

        //        if (customerEntity == null)
        //        {
        //            return NotFound();
        //        }

        //        var customerToPatch = _mapper.Map<CustomerForEditDto>(customerEntity);

        //        patchDocument.ApplyTo(customerToPatch, ModelState);

        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (!TryValidateModel(customerToPatch))
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        _mapper.Map(customerToPatch, customerEntity);

        //        await _repository.SaveChangesAsync();

        //        return NoContent();


        //    }
        //}


    
}