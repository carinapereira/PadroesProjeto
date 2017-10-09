
using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto> 
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
