using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Interpreter
{
    public class Subtracao : IExpression
    {
        private IExpression esquerda;
        private IExpression direita;

        public Subtracao(IExpression esquerda, IExpression direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int valorDireita = direita.Avalia();
            int valorEsquerda = esquerda.Avalia();

            return valorEsquerda - valorDireita;
        }
    }
}