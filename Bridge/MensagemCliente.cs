using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Bridge
{
    public class MensagemCliente : IMensagem
    {
        private string nome;

        public MensagemCliente(String nome)
        {
            this.nome = nome;
            Enviador = new EnviaPorEmail();
        }

        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o cliente {0}", nome);
        }
    }
}