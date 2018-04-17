using CSharpModeloDDD.Domain.Entities;
using CSharpModeloDDD.Domain.Interfaces.Repositories;
using CSharpModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CSharpModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}