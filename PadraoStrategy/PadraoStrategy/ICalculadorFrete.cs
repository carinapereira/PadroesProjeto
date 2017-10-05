using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public interface ICalculadorFrete
    {
        decimal CalcularFrete(Pedido pedido);
    }
}
