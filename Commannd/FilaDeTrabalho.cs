using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2.Commannd
{
    public class FilaDeTrabalho
    {
        private IList<ICommand> commands = new List<ICommand>();

        public void Adiciona(ICommand command)
        {
            commands.Add(command);
        }

        public void Processa()
        {
            foreach (var command in commands)
            {
                command.Executa();
            }
        }
    }
}