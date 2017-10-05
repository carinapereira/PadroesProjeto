using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedidoUm = new Pedido(new CalculadorFretePadrao());
            pedidoUm.valorPedido = 100;
            Console.WriteLine("Pedido com valor de frete padrão R$ 10.00: ");
            Console.WriteLine(pedidoUm.CalcularFrete());

            var pedidoDois = new Pedido(new CalculadorFreteExpresso());
            pedidoDois.valorPedido = 250;

            Console.WriteLine("Pedido com valor de frete Expresso R$ 25.00: ");
            Console.WriteLine(pedidoDois.CalcularFrete());
            Console.ReadKey();
        }
    }
}
