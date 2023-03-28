using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAutonomoBCCIII.Properties
{
    public class ControlePirata
    {
        public string pirataSelecionado;
        public ContainerInicial containerInicial;
        public string cartaSelecionada;

        public ControlePirata (ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
        }
    }
}
