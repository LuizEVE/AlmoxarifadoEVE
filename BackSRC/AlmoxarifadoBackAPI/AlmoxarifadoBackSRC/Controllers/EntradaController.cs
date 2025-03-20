using AlmoxarifadoBackSRC.DTO;
using AlmoxarifadoBackSRC.Models;
using AlmoxarifadoBackSRC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackSRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaRepositorio _db;
        public EntradaController(IEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaEntrada")]
        public IActionResult listaEntradas()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Entrada")]
        public IActionResult listaEntradas(EntradaDTO Entrada)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == Entrada.Codigo));
        }

        [HttpPost("/criarEntrada")]
        public IActionResult criarEntrada(EntradaCadastroDTO Entrada)
        {

            var novaEntrada = new Entrada()
            {
                DataEntrada = Entrada.DataEntrada,
                CodigoFornecedor = Entrada.CodigoFornecedor,
                Observacao = Entrada.Observacao
            };
            //_Entradas.Add(novaEntrada);
            _db.Add(novaEntrada);
            return Ok("Cadastro com Sucesso");
        }
    }
}
