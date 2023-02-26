using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern2.Visitor;

namespace DesignPattern2.Interpreter
{
    public class Multiplicacao : IExpression
    {
        private IExpression esquerda;
        private IExpression direita;

        public Multiplicacao(IExpression esquerda, IExpression direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int valorDireita = direita.Avalia();
            int valorEsquerda = esquerda.Avalia();

            return valorEsquerda * valorDireita;
        }
    }
}