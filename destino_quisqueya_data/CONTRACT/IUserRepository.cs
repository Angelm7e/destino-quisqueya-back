using destino_quisqueya_back.MODELS;


namespace destino_quisqueya_data.CONTRACT
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> UpdateUser(User user);
        public Task<int> DeleteUser(Guid id);
    }
}
