using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterClientesEspeciais();
    }
}