using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
