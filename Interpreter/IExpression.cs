using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern2.Visitor;

namespace DesignPattern2.Interpreter
{
    public interface IExpression
    {
        public int Avalia();
        public void Aceita(IVisitor impressora);

    }
}