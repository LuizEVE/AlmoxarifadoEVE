using AlmoxarifadoBackSRC.DTO;
using AlmoxarifadoBackSRC.Models;
using AlmoxarifadoBackSRC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackSRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepositorio _db;
        public FornecedorController(IFornecedorRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaFornecedor")]
        public IActionResult listaFornecedors()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Fornecedor")]
        public IActionResult listaFornecedors(FornecedorDTO Fornecedor)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == Fornecedor.Codigo));
        }

        [HttpPost("/criarFornecedor")]
        public IActionResult criarFornecedor(FornecedorCadastroDTO Fornecedor)
        {

            var novaFornecedor = new Fornecedor()
            {
                NomeFornecedor = Fornecedor.NomeFornecedor,
                Endereco = Fornecedor.Endereco,
                Bairro = Fornecedor.Bairro,
                Cidade = Fornecedor.Cidade,
                Estado = Fornecedor.Estado,
                Telefone = Fornecedor.Telefone,
                CNPJ = Fornecedor.CNPJ
            };
            //_Fornecedors.Add(novaFornecedor);
            _db.Add(novaFornecedor);
            return Ok("Cadastro com Sucesso");
        }
    }
}
