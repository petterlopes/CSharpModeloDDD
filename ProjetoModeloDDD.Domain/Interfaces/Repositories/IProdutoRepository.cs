using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}