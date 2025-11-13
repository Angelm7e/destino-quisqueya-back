
using destino_quisqueya_back._0.DBontext;
using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.CONTRACT;
using Microsoft.EntityFrameworkCore;

namespace destino_quisqueya_data.REPOSITORY
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDBContext _context;
        public UserRepository(AppDBContext ctx )
        {
            _context = ctx;
        }

        public Task<int> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                var data = await _context.Users.ToListAsync();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }

}


