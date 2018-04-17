using CSharpModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}