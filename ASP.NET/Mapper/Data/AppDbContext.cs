using Mapper.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace Mapper.Data
{
    public class AppDbContext : DbContext
    {

        private readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transation> Transations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conecctionString = _configuration.GetConnectionString("SqlServer");

            optionsBuilder.UseSqlServer(conecctionString);
            
        }


    }
}
