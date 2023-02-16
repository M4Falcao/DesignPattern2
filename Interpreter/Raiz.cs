using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Interpreter
{
    public class Raiz : IExpression
    {
        private IExpression numero;

        public Raiz(IExpression numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            int num = numero.Avalia();
            return (int)Math.Sqrt(num);
        }
    }
}