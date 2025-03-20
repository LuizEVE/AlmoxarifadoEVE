using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public interface ISecretariaRepositorio
    {
        void Add(Secretaria Secretaria);

        List<Secretaria> GetAll();
    }
}
