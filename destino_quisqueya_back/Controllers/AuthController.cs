using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.DTO;
using MEDICORE.CORE.INTERFACE;
using Microsoft.AspNetCore.Mvc;

namespace destino_quisqueya_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _AuthService;
        public AuthController(IAuthService AuthService)
        {
            _AuthService = AuthService;
        }

        [HttpPost]
        
        public async Task<IActionResult> LogIn(logInDTO value)
        {
            try
            {
                var data = await _AuthService.GetUserByEmail(value.email);

                if(data == null)
                {
                    return NotFound("usuario no existe");
                }
                    

                if (data.password != value.password)
                {
                    return BadRequest("Revisar credenciales");
                }
                else
                {
                    return Ok();
                }

               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
