using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.CONTRACT;
using destino_quisqueya_data.DTO;
using MEDICORE.CORE.INTERFACE;

namespace destino_quisqueya_core.SERVICE
{
    public class AuthServices : IAuthService
    {
        private readonly IAuthRepository _repo;

        public AuthServices(IAuthRepository repo)

        {
            _repo = repo;
        }

        public Task<User> Login(logInDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            return _repo.GetUserByEmail(email);
        }
    }
}
