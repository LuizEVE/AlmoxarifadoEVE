using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public class SecretariaRepositorio : ISecretariaRepositorio
    {
        private readonly Context _db;

        public SecretariaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Secretaria Secretaria)
        {

            _db.Secretaria.Add(Secretaria);
            _db.SaveChanges();
        }

        public List<Secretaria> GetAll()
        {
            return _db.Secretaria.ToList();
        }
    }
}
