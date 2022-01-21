using DevSmash___Projeto_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace DevSmash___Projeto_Final
{
    public class SiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "server=localhost;database=animareskilling_projetofinal;user id=root;password=akamarus94";
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));

        }

        public DbSet<Servicos> Servicos { get; set; }

        public DbSet<DevSmash___Projeto_Final.Models.Post> Post { get; set; }

        public DbSet<DevSmash___Projeto_Final.Models.Integrante> Integrante { get; set; }

        public DbSet<DevSmash___Projeto_Final.Models.Midia> Midia { get; set; }
    }
}
