using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagement.DataAccess.Repositories;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IBusinessLayer _business;
        private readonly IDBRepository _dBRepository;
        public EventController(IBusinessLayer business, IDBRepository dbRepository)
        {
            _business = business ?? throw new ArgumentNullException(nameof(business));
            _dBRepository = dbRepository ?? throw new ArgumentNullException(nameof(dbRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventsDto>>> GetEvents(long userId)
        {
            var events = await _business.GetEvents(userId);  
            if (!await _dBRepository.UserExistsAsync(userId))
            {
                return NotFound();
            }
            return Ok(events);

        }
    }
}
