using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3A2A2GA\\SQLEXPRESS; initial catalog=ExoApi; Integrated Security=true");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
