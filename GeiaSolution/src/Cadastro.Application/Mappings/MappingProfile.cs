using AutoMapper;
using Cadastro.Application.DTO;
using Cadastro.Domain.Entities;

namespace Cadastro.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}