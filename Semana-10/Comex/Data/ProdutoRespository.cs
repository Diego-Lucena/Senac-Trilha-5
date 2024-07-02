
using Comex.Modelos;

namespace Comex.Data
{
    public class ProdutoRespository
    {
        private ComexDbContext _dbContext;
        public ProdutoRespository(ComexDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> Listar()
        {
            return _dbContext.Produto.ToList();
        }

        public void Adicionar(Produto produto)
        {
            _dbContext.Produto.Add(produto);
            _dbContext.SaveChanges();
        }
    }
}
