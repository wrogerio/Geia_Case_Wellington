using Cadastro.Application.Interfaces;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Services;

namespace Cadastro.Application
{
    public class ProdutoAppService: AppServiceBase<Produto>, IProdutoAppService
    {
        public ProdutoAppService(IServiceBase<Produto> serviceBase) : base(serviceBase)
        {
        }
    }
}
