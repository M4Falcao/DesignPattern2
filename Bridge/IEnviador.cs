using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Bridge
{
    public interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}