namespace GerenciadorLivros.Core.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; private set; }

        protected EntityBase()
        {
        }
    }
}
