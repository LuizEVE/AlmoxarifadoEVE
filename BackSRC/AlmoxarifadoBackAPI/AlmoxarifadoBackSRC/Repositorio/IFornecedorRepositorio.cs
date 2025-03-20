using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface IFornecedorRepositorio
    {
        void Add(Fornecedor Fornecedor);

        List<Fornecedor> GetAll();
    }
}
