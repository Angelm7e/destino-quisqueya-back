


using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.DTO;

namespace MEDICORE.CORE.INTERFACE
{
    public interface IAuthService
    {
        public Task<User> Login(logInDTO data);
        public Task<User> GetUserByEmail(string email);
    }
}
