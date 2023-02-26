using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Commannd
{
    public class PagaPedido : ICommand
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando pedido do " + pedido.Cliente);
            pedido.Paga();
        }
    }
}