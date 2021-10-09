using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Application.DTO;
using Cadastro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _service;

        public ProdutosController(IProdutoAppService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var produtos = _service.GetAll().Where(x => x.Deleted == 0).ToList();
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ProdutoDTO produto)
        {
            // Validação da Data de Validade ao Inserir
            if (produto.DataValidade != null && DateTime.Now.Date > produto.DataValidade)
                ModelState.AddModelError("Preco", "A validade não pode ser menor que a data Atual");

            if (!ModelState.IsValid)
                return View(produto);

            _service.Create(produto);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(Guid id)
        {
            var produto = _service.GetAll().FirstOrDefault(x => x.Id == id);
            produto.PrecoAnterior = produto.Preco;
            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(ProdutoDTO produto)
        {
            // Validação para não alterar o preco se a data for menor que hoje
            if (produto.DataValidade != null && DateTime.Now.Date > produto.DataValidade)
            {
                if(produto.Preco != produto.PrecoAnterior)
                    ModelState.AddModelError("Preco", "A validade não pode ser menor que a data Atual");
            }

            if (!ModelState.IsValid)
                return View(produto);

            _service.Update(produto);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Excluir(Guid id)
        {
            _service.Remove(_service.GetById(id));
            return Json("ok");
        }

    }
}
