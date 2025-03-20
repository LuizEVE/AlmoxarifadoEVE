using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public class SaidaRepositorio : ISaidaRepositorio
    {
        private readonly Context _db;

        public SaidaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Saida Saida)
        {

            _db.Saida.Add(Saida);
            _db.SaveChanges();
        }

        public List<Saida> GetAll()
        {
            return _db.Saida.ToList();
        }
    }
}
