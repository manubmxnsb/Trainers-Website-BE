
using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagement.DataAccess.Repositories;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IUserService _business;
      
        public EventsController(IUserService business)
        {
            _business = business ?? throw new ArgumentNullException(nameof(business));
          
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventsDto>>> GetEvents(long userId)
        {
            if (!await _business.UserExistsAsync(userId))
            {
                return NotFound();
            }
            var events = await _business.GetEvents(userId);  

            return Ok(events);

        }

    }
}
