using destino_quisqueya_back.MODELS;
using MEDICORE.CORE.INTERFACE;
using Microsoft.AspNetCore.Mvc;

namespace destino_quisqueya_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        
        public async Task<IEnumerable<User>> GetUsers()
        {
            try
            {
                var data = await _userService.GetAllUsers();

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
