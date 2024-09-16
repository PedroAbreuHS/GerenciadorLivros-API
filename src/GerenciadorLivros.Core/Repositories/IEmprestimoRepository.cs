using GerenciadorLivros.Core.Entities;

namespace GerenciadorLivros.Core.Repositories
{
    public interface IEmprestimoRepository : IRepository<Emprestimo>
    {
        void CadastrarDataDevolucao();
    }
}
