using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class Pedido
    {
        public decimal valorPedido { get; set; }

        private ICalculadorFrete _calculadorFrete;
        public Pedido( ICalculadorFrete calculadorFrete)
        {
            _calculadorFrete = calculadorFrete;
        }

        public decimal CalcularFrete()
        {
            return _calculadorFrete.CalcularFrete(this);
        }
    }
}
