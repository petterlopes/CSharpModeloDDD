using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}