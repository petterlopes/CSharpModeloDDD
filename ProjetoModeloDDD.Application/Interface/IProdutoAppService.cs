using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}