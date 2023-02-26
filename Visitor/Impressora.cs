using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern2.Interpreter;

namespace DesignPattern2.Visitor
{
    public class Impressora : IVisitor
    {
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Avalia());
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write("-");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}