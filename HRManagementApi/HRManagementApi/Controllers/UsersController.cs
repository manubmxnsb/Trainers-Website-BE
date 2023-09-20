using Microsoft.AspNetCore.Mvc;
using HRManagement.Business.Services;


namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet]
        public async Task<ActionResult> GetUser(long id )
        {
            var user = await _userService.GetUser(id);
            return Ok(user);
        }
    }
}
