
using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes);
    }
}
