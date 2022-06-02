using Chapter.WebApi2.Models;

namespace Chapter.WebApi2.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usario);

        void Deletar(int id);

        void Atualizar(int id, Usuario usuario);

        Usuario Login(string email, string senha);
       
    }
}
