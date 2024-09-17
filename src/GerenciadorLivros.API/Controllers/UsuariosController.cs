using GerenciadorLivros.Application.DTOs_Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivros.API.Controllers
{
    public class UsuariosController : ControllerBase
    {
        //Create
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarUsuarioModel usuario)
        {
            return CreatedAtAction(nameof(ObterPorId), new { usuario.Id }, usuario);
        }


        //Read
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            return Ok();
        }

        [HttpGet("{query}")] //api/livros?query=net core
        public async Task<IActionResult> ObterTodosPorFiltro(string query)
        {
            //return NotFound();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            //return NotFound();

            return Ok();
        }

        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, AtualizarUsuarioModel usuario)
        {
            return NoContent();
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            //Buscar, se não existir, retornar NotFound()

            //Remover, no caso do projeto, configurar como indisponível
            return NoContent();

        }
    }
}
