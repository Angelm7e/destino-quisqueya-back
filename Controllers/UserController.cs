using destino_quisqueya_back.MODELS;
using Microsoft.AspNetCore.Mvc;

namespace destino_quisqueya_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        
        public IEnumerable<User> GetUsers()
        {
            return new List<User>();
        }
    }
}
