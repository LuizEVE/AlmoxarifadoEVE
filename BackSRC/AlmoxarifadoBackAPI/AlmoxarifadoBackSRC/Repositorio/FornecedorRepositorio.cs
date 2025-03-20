using AlmoxarifadoBackSRC.Models;

namespace AlmoxarifadoBackSRC.Repositorio
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly Context _db;

        public FornecedorRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Fornecedor Fornecedor)
        {

            _db.Fornecedor.Add(Fornecedor);
            _db.SaveChanges();
        }

        public List<Fornecedor> GetAll()
        {
            return _db.Fornecedor.ToList();
        }
    }
}
