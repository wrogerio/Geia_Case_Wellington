using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Cadastro.Application.DTO;
using Cadastro.Application.Interfaces;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces.Services;

namespace Cadastro.Application
{
    public class ProdutoAppService: IProdutoAppService
    {
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoService serviceBase, IMapper mapper)
        {
            _service = serviceBase;
            _mapper = mapper;
        }

        public void Create(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _service.Create(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _service.GetAll().ToList();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }

        public ProdutoDTO GetById(Guid id)
        {
            var produto = _service.GetById(id);
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public void Update(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _service.Update(produto);
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _service.Remove(produto);
        }
    }
}
