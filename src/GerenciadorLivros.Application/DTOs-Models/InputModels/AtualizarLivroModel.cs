namespace GerenciadorLivros.Application.DTOs_Models.InputModels
{
    public class AtualizarLivroModel
    {
        public string Titulo { get; set; } = null!;
        public string Autor { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public int AnoPublicacao { get; set; }
    }
}
