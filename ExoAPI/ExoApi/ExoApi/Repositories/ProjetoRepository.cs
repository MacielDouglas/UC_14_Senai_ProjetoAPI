using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _context;
        public ProjetoRepository(ExoApiContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Projeto projeto)
        {
            Projeto buscarProjeto = _context.Projetos.Find(id);

            if (buscarProjeto != null)
            {
                buscarProjeto.Titulo = projeto.Titulo;
                buscarProjeto.DataInicio = projeto.DataInicio;
                buscarProjeto.StatusProjeto = projeto.StatusProjeto;
                buscarProjeto.Area = projeto.Area;
                buscarProjeto.Tecnologias = projeto.Tecnologias;
            }

            _context.Projetos.Update(buscarProjeto);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = _context.Projetos.Find(id);

            _context.Projetos.Remove(projeto);

            _context.SaveChanges();
        }
    }
}
