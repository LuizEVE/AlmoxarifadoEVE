using AlmoxarifadoBackSRC.DTO;
using AlmoxarifadoBackSRC.Models;
using AlmoxarifadoBackSRC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackSRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretariaController : ControllerBase
    {
        private readonly ISecretariaRepositorio _db;
        public SecretariaController(ISecretariaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaSecretaria")]
        public IActionResult listaSecretarias()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Secretaria")]
        public IActionResult listaSecretarias(SecretariaDTO Secretaria)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == Secretaria.Codigo));
        }

        [HttpPost("/criarSecretaria")]
        public IActionResult criarSecretaria(SecretariaCadastroDTO Secretaria)
        {

            var novaSecretaria = new Secretaria()
            {
                NomeSecretaria = Secretaria.NomeSecretaria,
                Endereco = Secretaria.Endereco,
                Bairro = Secretaria.Bairro,
                Cidade = Secretaria.Cidade,
                Estado = Secretaria.Estado,
                Telefone = Secretaria.Telefone,
                CNPJ = Secretaria.CNPJ
            };
            //_Secretarias.Add(novaSecretaria);
            _db.Add(novaSecretaria);
            return Ok("Cadastro com Sucesso");
        }
    }
}
