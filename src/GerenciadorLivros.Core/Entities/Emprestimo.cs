namespace GerenciadorLivros.Core.Entities
{
    public class Emprestimo : EntityBase
    {
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } 
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public Emprestimo(int idUsuario, Usuario usuario, int idLivro, Livro livro, DateTime dataEmprestimo)
            : base()
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
            IdLivro = idLivro;
            Livro = livro;
            DataEmprestimo = DateTime.Now; //Data do empréstimo no momento da criação.
        }

        public void DevolverLivro()
        {
            DataDevolucao = DateTime.Now; //Data de devolução nomomento da ação.
        }

        public bool EstaAtrasado()
        {
            if (!DataDevolucao.HasValue) return false;

            return DataDevolucao.HasValue && (DateTime.Now - DataEmprestimo).TotalDays > 7;
        }

        public int DiasAtraso()
        {
            if (DataDevolucao.HasValue)
            {
                return (int)(DateTime.Now - DataDevolucao.Value).TotalDays;
            }
            return 0;
        }

        public override string ToString()
        {
            var statusDevolucao = DataDevolucao.HasValue ? $"Devolvido em: {DataDevolucao.Value}" : "Ainda não devolvido";
            return $"Empréstimo de {Livro.Titulo} para {Usuario.Nome}, Data do empréstimo: {DataEmprestimo}, {statusDevolucao}";
        }
    }
}
