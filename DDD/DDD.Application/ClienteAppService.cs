
using DDD.Application.Interface;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClienteEspeciais(_clienteService.GetAll());
        }
    }
}
