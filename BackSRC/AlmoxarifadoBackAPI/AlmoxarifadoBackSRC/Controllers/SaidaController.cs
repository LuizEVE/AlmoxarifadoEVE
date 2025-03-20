using AlmoxarifadoBackSRC.DTO;
using AlmoxarifadoBackSRC.Models;
using AlmoxarifadoBackSRC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackSRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaRepositorio _db;
        public SaidaController(ISaidaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaSaida")]
        public IActionResult listaSaidas()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Saida")]
        public IActionResult listaSaidas(SaidaDTO Saida)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == Saida.Codigo));
        }

        [HttpPost("/criarSaida")]
        public IActionResult criarSaida(SaidaCadastroDTO Saida)
        {

            var novaSaida = new Saida()
            {
                DataSaida = Saida.DataSaida,
                CodigoSecretaria = Saida.CodigoSecretaria,
                Observacao = Saida.Observacao
            };
            //_Saidas.Add(novaSaida);
            _db.Add(novaSaida);
            return Ok("Cadastro com Sucesso");
        }
    }
}
