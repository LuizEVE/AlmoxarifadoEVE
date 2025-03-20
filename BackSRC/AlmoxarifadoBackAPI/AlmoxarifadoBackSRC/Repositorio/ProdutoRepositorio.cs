using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly Context _db;

        public ProdutoRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Produto Produto)
        {

            _db.Produto.Add(Produto);
            _db.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _db.Produto.ToList();
        }
    }
}
