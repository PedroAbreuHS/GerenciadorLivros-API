using GerenciadorLivros.Core.Entities;

namespace GerenciadorLivros.Application.DTOs_Models.InputModels
{
    public class CadastrarUsuarioModel : EntityBase
    {
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
