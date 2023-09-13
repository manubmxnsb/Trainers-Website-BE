using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Services;


namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _business;
        public UsersController(IUserService business)
        {
            _business = business ?? throw new ArgumentNullException(nameof(business));
        }

        [HttpGet]
        public async Task<ActionResult> GetUserWithEvents(long id, bool includeEvents )
        {
            var user = await _business.GetUserWithEvents(id, includeEvents);
            if (user == null)
            {
                return NotFound();
            }
           return Ok(user);
        }

    }
}
