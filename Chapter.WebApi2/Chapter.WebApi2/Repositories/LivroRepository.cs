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

        public Livro BuscarLivroId(int id) //metodo publico, retorna um livro específico, nome do método (BuscarLivroId), o id vem ocomo argumento
        {
            return _context.Livros.Find(id); // retorno, _context(conexão c/ banco) Livros(nome da tabela) .Find(id) irá buscar um elemento da tablea que corresponde ao id.
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro); // Faz a uma alteração na tabela, seria como um insert

            _context.SaveChanges(); // Salva a alteração na tabela
        }

        public void Atualizar(int id, Livro livro) //primeiro ele irá fazer uma consulta no banco para saber se o id já existe, se sim volta com as informações
        {
            Livro livroBuscado = _context.Livros.Find(id);

            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }

            _context.Livros.Update(livroBuscado);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livro = _context.Livros.Find(id);

            _context.Livros.Remove(livro);

            _context.SaveChanges();
        }
    }
}
