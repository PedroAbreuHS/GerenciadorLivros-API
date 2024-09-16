namespace GerenciadorLivros.Core.Repositories
{
    public interface IRepository<T>
    {
        Task Cadastrar(T obj);
        Task ConsultarTodos();
        Task ConsultarUm(int id);
        Task Atualizar(int id);
        Task Remover(int id);
    }
}
