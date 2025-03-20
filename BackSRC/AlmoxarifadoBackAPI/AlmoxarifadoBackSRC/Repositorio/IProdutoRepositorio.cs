using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface IProdutoRepositorio
    {

       void Add(Produto Produto);

        List<Produto> GetAll();
    }
}
