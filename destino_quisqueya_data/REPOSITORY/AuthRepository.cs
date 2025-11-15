
using destino_quisqueya_back._0.DBontext;
using destino_quisqueya_back.MODELS;
using destino_quisqueya_data.CONTRACT;
using destino_quisqueya_data.DTO;
using Microsoft.EntityFrameworkCore;

namespace destino_quisqueya_data.REPOSITORY
{
    public class AuthRepository : IAuthRepository
    {

        private readonly AppDBContext _context;
        public AuthRepository(AppDBContext ctx )
        {
            _context = ctx;
        }

        public async Task<User> Login(logInDTO data)
        {
            try
            {
                throw new NotImplementedException();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<User> GetUserByEmail(string email)
        {
            try
            {
                User data = await _context.Users.Where(e => e.email == email).FirstOrDefaultAsync();

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}


