


using destino_quisqueya_back.MODELS;

namespace MEDICORE.CORE.INTERFACE
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> UpdateUser(User user);
        public Task<int> DeleteUser(Guid id);
    }
}
