using AlmoxarifadoBackSRC.DTO;
using AlmoxarifadoBackSRC.Models;
using AlmoxarifadoBackSRC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackSRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _db;
        public ProdutoController(IProdutoRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaProduto")]
        public IActionResult listaProdutos()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Produto")]
        public IActionResult listaProdutos(ProdutoDTO Produto)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == Produto.Codigo));
        }

        [HttpPost("/criarProduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO Produto)
        {

            var novaProduto = new Produto()
            {
                Descricao = Produto.Descricao,
                UnMedida = Produto.UnMedida,
                EstoqueAtual = Produto.EstoqueAtual,
                EPermanente = Produto.EPermanente,
                CodigoCategoria = Produto.CodigoCategoria
            };
            //_Produtos.Add(novaProduto);
            _db.Add(novaProduto);
            return Ok("Cadastro com Sucesso");
        }
    }
}
