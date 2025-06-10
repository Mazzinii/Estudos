using ConnectingSqlServer.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace ConnectingSqlServer.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aula> Aulas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conectionString = "Server=NITSOGA\\SQLSERVER;Database=EscolaDB;User ID=sa;Password=Ano2025@;Trusted_Connection=False;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(conectionString);
    
        }


    }
}
