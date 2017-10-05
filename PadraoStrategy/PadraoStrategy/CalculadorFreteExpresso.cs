﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class CalculadorFreteExpresso : ICalculadorFrete
    {
        public decimal CalcularFrete(Pedido pedido)
        {
            return pedido.valorPedido + 25;
        }
    }
}
