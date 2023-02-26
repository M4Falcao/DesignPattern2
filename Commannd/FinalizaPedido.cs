using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Commannd
{
    public class FinalizaPedido : ICommand
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Finalizando pedido do " + pedido.Cliente);
            pedido.Finaliza();
        }
    }
}