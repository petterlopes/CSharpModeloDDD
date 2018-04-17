using CSharpModeloDDD.Domain.Entities;
using CSharpModeloDDD.Domain.Interfaces.Repositories;

namespace CSharpModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}