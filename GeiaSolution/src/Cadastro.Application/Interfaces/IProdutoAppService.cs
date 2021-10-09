using System;
using System.Collections.Generic;
using Cadastro.Application.DTO;
using Cadastro.Domain.Entities;

namespace Cadastro.Application.Interfaces
{
    public interface IProdutoAppService
    {
        void Create(ProdutoDTO produto);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(Guid id);

        void Update(ProdutoDTO produto);

        void Remove(ProdutoDTO produto);
    }
}