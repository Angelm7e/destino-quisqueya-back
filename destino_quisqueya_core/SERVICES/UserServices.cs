using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.CONTRACT;
using MEDICORE.CORE.INTERFACE;


namespace destino_quisqueya_core.SERVICE
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _repo;

        public UserServices(IUserRepository repo)

        {
            _repo = repo;
        }

        public Task<int> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
