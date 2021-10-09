using Cadastro.Application.Interfaces;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Services;

namespace Cadastro.Application
{
    public class ProdutoAppService: AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _service;
        public ProdutoAppService(IProdutoService service) : base(service)
        {
            _service = service;
        }
    }
}
