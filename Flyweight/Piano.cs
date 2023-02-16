using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Flyweight
{
    public class Piano
    {
        public void Toca(IList<INota> notas)
        {
            foreach (var nota in notas)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}