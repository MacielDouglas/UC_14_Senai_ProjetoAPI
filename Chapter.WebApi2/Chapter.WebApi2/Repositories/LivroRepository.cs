using Chapter.WebApi2.Contexts;
using Chapter.WebApi2.Models;

namespace Chapter.WebApi2.Repositories
{
    public class LivroRepository // O Repositorio depende da conexão c/ banco para funcionar, isso é Injeção de dependencia.
    {
        private readonly ChapterContext _context; //variavel apenas de leitura para segurança não dá permissão de alteração
        public LivroRepository(ChapterContext context)  //método construtor para injeção de dependencia
        {
            _context = context; // variavel " _context " tem encapsulamento e um nível de segurança.
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
