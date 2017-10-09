using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using System.Linq;

namespace DDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p .Nome == nome);
        }
    }
}
