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
        public GetDadosDll getDadosDll;

        public struct pirata 
        {
            public int id;
            public int posicao;
            public System.Windows.Forms.Panel img;
        }

        public List<pirata> piratas;

        // -1 para indicar para que o não há um pirata selecionado, desculpe mas esse é o padrão do codigo do professor.
        public pirata pirataSelecionado = new pirata { id = -1, posicao = -1 };

        
        public ControlePirata(ContainerInicial containerInicial)
        { 
            this.containerInicial = containerInicial;
            this.getDadosDll = containerInicial.getDadosDll;

            piratas = new List<pirata>()
            {
                new pirata {id = 0, posicao = 0, img = this.containerInicial.imgPirata0},
                new pirata {id = 1, posicao = 0, img = this.containerInicial.imgPirata1},
                new pirata {id = 2, posicao = 0, img = this.containerInicial.imgPirata2},
                new pirata {id = 3, posicao = 0, img = this.containerInicial.imgPirata3},
                new pirata {id = 4, posicao = 0, img = this.containerInicial.imgPirata4},
                new pirata {id = 5, posicao = 0, img = this.containerInicial.imgPirata5}
            };
        }

        public void SelecionarPirata(int id)
        {
            if ( this.pirataSelecionado.id != -1) 
                this.pirataSelecionado.img.BackColor = Color.White;

            if (this.pirataSelecionado.id == id && this.containerInicial.botOn == false)
            {
                this.pirataSelecionado.id = -1;
                this.pirataSelecionado.posicao = -1;
                this.pirataSelecionado.img.BackColor = Color.White;
                return;
            }
            
            this.pirataSelecionado = piratas[id];
            this.pirataSelecionado.img.BackColor = Color.Red;
        }

       public void SetPosicao(int idPirata, int novaPosicao)
        {
            if (idPirata == -1) return;
           
            pirata pirataMudado = this.piratas[idPirata];
            Point posicaoXYpirata = this.getDadosDll.posicoesMapeadas.Find(p => p.posicao == novaPosicao+1).posicaXY;

            pirataMudado.posicao = novaPosicao;
            pirataMudado.img.Location = posicaoXYpirata;

            this.piratas[idPirata] = pirataMudado;
            this.pirataSelecionado = pirataMudado;
        }

    }
}
