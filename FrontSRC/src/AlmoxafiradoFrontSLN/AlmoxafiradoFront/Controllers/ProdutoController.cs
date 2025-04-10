using AlmoxafiradoFront.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AlmoxafiradoFront.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://localhost:44366/listaprodutos";
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                produtos = JsonSerializer.Deserialize<List<ProdutoDTO>>(json);
                ViewBag.Produtos = produtos;


            }
            catch (Exception)
            {
                return View();

            }

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string descricao, string unMedida, int estoqueAtual, bool ePermanente, int codigoCategoria)
        {
            var url = "https://localhost:44366/criarproduto";


            using HttpClient client = new HttpClient();
            try
            {
                var produtoNovo = new ProdutoNovoDTO { descricao = descricao, unMedida = unMedida, estoqueAtual = estoqueAtual, ePermanente = ePermanente, codigoCategoria = codigoCategoria};

                var cartoriaSerializada = JsonSerializer.Serialize<ProdutoNovoDTO>(produtoNovo);

                var jsonContent = new StringContent(cartoriaSerializada, Encoding.UTF8, "application/json");


                HttpResponseMessage response = client.PostAsync(url, jsonContent).Result;
                response.EnsureSuccessStatusCode();

            }
            catch (Exception)
            {
                return View();

            }


            return RedirectToAction("Index");
        }
    }
}
