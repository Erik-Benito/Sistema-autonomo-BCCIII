using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace sistemaAutonomoBCCIII.Properties
{
    public class ControlePirata
    {
        public GetDadosDll dados;
        public ContainerInicial containerInicial;
        public int pirataSelecionado;

        public int posicaoPirata1 = 0;
        public int posicaoPirata2 = 0;
        public int posicaoPirata3 = 0;
        public int posicaoPirata4 = 0;
        public int posicaoPirata5 = 0;
        public int posicaoPirata6 = 0;

        public ControlePirata(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
        }

        
        public int SelecionarPirata(int pirataSelecionado)
        {
            switch (pirataSelecionado)
            {
                case 0:
                    return posicaoPirata1;
                case 1:
                    return posicaoPirata2;
                case 2:
                    return posicaoPirata3;
                case 3:
                    return posicaoPirata4;
                case 4:
                    return posicaoPirata5;
                case 5:
                    return posicaoPirata6;
                default:
                    return 150;
            }
        }
        public void SetPosicao(int pirataSelecionado, int posicaoAtual)
        {
            switch (pirataSelecionado)
            {
                case 0:
                    posicaoPirata1 = posicaoAtual;
                    break;
                case 1:
                    posicaoPirata2 = posicaoAtual;
                    break;
                case 2:
                    posicaoPirata3 = posicaoAtual;
                    break;
                case 3:
                    posicaoPirata4 = posicaoAtual;
                    break;
                case 4:
                    posicaoPirata5 = posicaoAtual;
                    break;
                case 5:
                    posicaoPirata6 = posicaoAtual;
                    break;
            }
        }

    }
}
