using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}