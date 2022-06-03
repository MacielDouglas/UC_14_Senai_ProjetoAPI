using Chapter.WebApi2.Models;
using Chapter.WebApi2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Chapter.WebApi2.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    [Authorize(Roles = "1")]

    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //define qual o tipo do método, porem não pode ter dois metodos Get iguais dentro do controler,
        //é preciso colocar uma rota diferente em um ou se ele vem com um argumento a mais
        // a rota é feita igual foi no [Route("api/[controller]")]

        [HttpGet("{id}")] //não precisa criar uma rota específica pois nesse ele ira pegar o id pelo get.
        public IActionResult BuscarLivroId(int id)
        {
            try
            {
                Livro livro = _livroRepository.BuscarLivroId(id);

                if (livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);

            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);

                return StatusCode(201); //Status code personalizado.
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                _livroRepository.Atualizar(id, livro);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
