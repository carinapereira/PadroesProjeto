O padrão de projeto Strategy, consiste em criar regras de negocio diferente para cada cliente sem a necessidade 
de alterar o comportamento do programa. 

Este padrão, além de muito popular, é bem simples de ser entendido.
O padrão Strategy serve para “definir uma família de algoritmos, 
encapsular cada uma delas e torná-las intercambiáveis. 
Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam” (como definido no livro do GoF).
Em outras palavras, Strategy nos permite configurar uma classe com um de vários comportamentos,
utilizando o conceito de OO chamado de composição.

Vantagens
1. Programe para abstrações: notem que nosso Pedido não depende diretamente de nenhum calculador concreto e sim da interface ICalculadorDeFrete.
2. Open-closed principle: nosso Pedido não terá nenhum impacto caso o número de classes derivadas aumente (precisamos de um novo cálculo de frete) e nem se precisarmos alterar o algoritmo de algum calculador.