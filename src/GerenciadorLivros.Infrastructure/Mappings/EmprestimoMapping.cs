using GerenciadorLivros.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorLivros.Infrastructure.Mappings
{
    public class EmprestimoMapping : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
