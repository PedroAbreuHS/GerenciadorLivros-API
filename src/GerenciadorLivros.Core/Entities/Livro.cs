using GerenciadorLivros.Core.Entities.Enums;

namespace GerenciadorLivros.Core.Entities
{
    public class Livro : EntityBase
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public int AnoPublicacao { get; private set; }
        public StatusLivro StatusLivro { get; private set; }
        
        public Livro(string titulo, string autor, string iSBN, int anoPublicacao) 
            : base()
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public void Indisponivel()
        {
            if (StatusLivro == StatusLivro.Disponivel)
                StatusLivro = StatusLivro.Indisponivel;
        }

        public void Disponivel()
        {
            if(StatusLivro == StatusLivro.Indisponivel)
                StatusLivro = StatusLivro.Disponivel;
        }

        public override string ToString()
        {
            return $"{Titulo} ({AnoPublicacao}), Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}
