using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface IEntradaRepositorio
    {
        void Add(Entrada Entrada);

        List<Entrada> GetAll();
    }
}
