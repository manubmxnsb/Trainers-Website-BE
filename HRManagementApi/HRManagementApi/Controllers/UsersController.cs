using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Services;


namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService business)
        {
            _userService = business ?? throw new ArgumentNullException(nameof(business));
        }

        [HttpGet]
        public async Task<ActionResult> GetUser(long id )
        {
            var user = await _userService.GetUser(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
