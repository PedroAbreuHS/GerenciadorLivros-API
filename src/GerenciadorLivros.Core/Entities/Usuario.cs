namespace GerenciadorLivros.Core.Entities
{
    public class Usuario : EntityBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public bool EstaAtivo { get; private set; }
        public DateTime CadastradoEm { get; private set; }
        public List<Emprestimo> Emprestimos { get; set; }

        public Usuario(string nome, string email) : base()
        {            
            Nome = nome;
            Email = email;

            EstaAtivo = true;
            CadastradoEm = DateTime.Now;
            Emprestimos = new List<Emprestimo>();
        }

        public void Inativar()
        {
            if (EstaAtivo) 
                EstaAtivo = false;
        }

        public override string ToString()
        {
            return $"{Nome} - {Email}";
        }
    }
}
