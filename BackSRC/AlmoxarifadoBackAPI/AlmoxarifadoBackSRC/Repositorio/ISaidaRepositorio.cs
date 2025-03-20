using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface ISaidaRepositorio
    {
        void Add(Saida Saida);

        List<Saida> GetAll();
    }
}
