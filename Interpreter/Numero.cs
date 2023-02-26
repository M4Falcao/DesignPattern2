using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern2.Visitor;

namespace DesignPattern2.Interpreter
{
    public class Numero : IExpression
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return Valor;
        }
    }
}