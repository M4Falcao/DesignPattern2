using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern2.Visitor;

namespace DesignPattern2.Interpreter
{
    public class Subtracao : IExpression
    {
        public IExpression Esquerda { get; private set; }
        public IExpression Direita { get; private set; }

        public Subtracao(IExpression esquerda, IExpression direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }

        public int Avalia()
        {
            int valorDireita = Direita.Avalia();
            int valorEsquerda = Esquerda.Avalia();

            return valorEsquerda - valorDireita;
        }
    }
}