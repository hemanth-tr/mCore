using MessagesApi.Models;
using MessagesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessagesApi.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService) 
        { 
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<User> GetAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException(nameof(id));
            }

            var user = await _userService.GetUserAsync(id).ConfigureAwait(false);
            return user;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var user = await _userService.GetAllUsersAsync().ConfigureAwait(false);
            return user;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(UserModel user)
        {
            user.Validate();
            user = await _userService.CreateUserAsync(user).ConfigureAwait(false);
            return Ok(user);
        }
    }
}
