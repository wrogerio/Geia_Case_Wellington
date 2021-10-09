using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;

namespace Cadastro.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}