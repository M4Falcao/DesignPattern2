using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Flyweight
{
    public class Tocador
    {
        private NotasMusicais notas = new NotasMusicais();

        private IList<INota> musica;
        public Tocador()
        {
            musica = new List<INota>()
            {
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            };

        }

        public void Toca()
        {
            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}