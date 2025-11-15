using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.DTO;


namespace destino_quisqueya_data.CONTRACT
{
    public interface IAuthRepository
    {
        public Task<User> Login(logInDTO data);
        public Task<User> GetUserByEmail(string email);
    }
}
