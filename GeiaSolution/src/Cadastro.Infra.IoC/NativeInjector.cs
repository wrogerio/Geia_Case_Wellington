using Cadastro.Application;
using Cadastro.Application.Interfaces;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Domain.Services;
using Cadastro.Infra.Data.Context;
using Cadastro.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Infra.IoC
{
    public class NativeInjector
    {
        public static void RegisterApp(IServiceCollection service)
        {
            service.AddScoped<IProdutoAppService, ProdutoAppService>();
            service.AddScoped<IProdutoService, ProdutoService>();
            service.AddScoped<IProdutoRepository, ProdutoRepository>();
            service.AddScoped<GeiaContext>();
        }
    }
}
