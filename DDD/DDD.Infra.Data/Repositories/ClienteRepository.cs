using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;

namespace DDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
