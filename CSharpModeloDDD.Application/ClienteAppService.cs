using CSharpModeloDDD.Application.Interface;
using CSharpModeloDDD.Domain.Entities;
using CSharpModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IEnumerable<Cliente>> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(await _clienteService.GetAll());
        }
    }
}