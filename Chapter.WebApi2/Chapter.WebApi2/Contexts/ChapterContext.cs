using Chapter.WebApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.WebApi2.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        // vamos utilizar esse médoto para configurar o bando de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3A2A2GA\\SQLEXPRESS; initial catalog=Chapter; Integrated Security=true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; } //Essa classe livro está referenciando a planilha livros no banco de dados.(link da api c/ banco de dados)
    }

}
