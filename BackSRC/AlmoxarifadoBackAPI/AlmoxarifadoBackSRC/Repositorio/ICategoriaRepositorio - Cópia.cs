using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface ICategoriaRepositorio
    {
        void Add(Categoria categoria);

        List<Categoria> GetAll();
    }
}
