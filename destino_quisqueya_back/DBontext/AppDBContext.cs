

using destino_quisqueya_back.MODELS;
using Microsoft.EntityFrameworkCore;

namespace destino_quisqueya_back._0.DBontext
{
    public class AppDBContext : DbContext  //Microsoft.EntityFrameworkCore.SqlServer
    {
        public AppDBContext(DbContextOptions options): base(options) { }


        public DbSet<User> Users { get; set; }
    }
}
