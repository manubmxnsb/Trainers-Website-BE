﻿using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Models;
using AutoMapper;
using HRManagement.DataAccess.Repositories;
using HRManagement.Business.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBusinessLayer _business;
        public UserController(IBusinessLayer business)
        {
            _business = business ?? throw new ArgumentNullException(nameof(business));
        }


        [HttpGet("{id}")]

        public async Task<ActionResult> GetUser(long id)
        {
            var user = await _business.GetUser(id);
            if (user != null)
            {
                return Ok(user);     
            }

            else { return NotFound(); }
        }

        [HttpGet]
        public async Task<ActionResult> GetUserWithEvents(long id, bool includeEvents )
        {
            var user = await _business.GetUserWithEvents(id, includeEvents);
            if (user == null)
            {
                return NotFound();
            }
            if(includeEvents) { 
                return Ok(user);
            }
           else { return NotFound(user); }  

          //  return Ok(user);
      
        }
        //// GET: api/<UserController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UserController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
