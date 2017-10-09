
using DDD.Domain.Entities;
using System.Collections.Generic;

namespace DDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
