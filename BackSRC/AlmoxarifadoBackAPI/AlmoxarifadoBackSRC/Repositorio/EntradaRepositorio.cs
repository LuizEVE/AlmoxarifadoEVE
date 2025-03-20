using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public class EntradaRepositorio : IEntradaRepositorio
    {
        private readonly Context _db;

        public EntradaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Entrada Entrada)
        {

            _db.Entrada.Add(Entrada);
            _db.SaveChanges();
        }

        public List<Entrada> GetAll()
        {
            return _db.Entrada.ToList();
        }
    }
}
