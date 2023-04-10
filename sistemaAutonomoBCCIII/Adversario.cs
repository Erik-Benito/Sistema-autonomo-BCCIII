using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sistemaAutonomoBCCIII.Properties.ControlePirata;

namespace sistemaAutonomoBCCIII
{
    public class Adversario
    {
        public ContainerInicial containerInicial;
        public GetDadosDll getDadosDll;
        public Tratamentos tratamentos = new Tratamentos();

        public int id;
        private List<pirata> piratas;
        public string ultimaAtt;


        public Adversario(ContainerInicial containerInicial, int adversarioNumero, int id)
        {
            this.containerInicial = containerInicial;
            this.getDadosDll = containerInicial.getDadosDll;

            switch (adversarioNumero)
            {
                case 1:
                    piratas = new List<pirata>()
                    {
                        new pirata {id = 0, posicao = 0, img = this.containerInicial.ad1Img0},
                        new pirata {id = 1, posicao = 0, img = this.containerInicial.ad1Img1},
                        new pirata {id = 2, posicao = 0, img = this.containerInicial.ad1Img2},
                        new pirata {id = 3, posicao = 0, img = this.containerInicial.ad1Img3},
                        new pirata {id = 4, posicao = 0, img = this.containerInicial.ad1Img4},
                        new pirata {id = 5, posicao = 0, img = this.containerInicial.ad1Img5},
                    };
                    break;
                case 2:
                    piratas = new List<pirata>()
                    {
                        new pirata {id = 0, posicao = 0, img = this.containerInicial.ad2Img0},
                        new pirata {id = 1, posicao = 0, img = this.containerInicial.ad2Img1},
                        new pirata {id = 2, posicao = 0, img = this.containerInicial.ad2Img2},
                        new pirata {id = 3, posicao = 0, img = this.containerInicial.ad2Img3},
                        new pirata {id = 4, posicao = 0, img = this.containerInicial.ad2Img4},
                        new pirata {id = 5, posicao = 0, img = this.containerInicial.ad2Img5},
                    };
                    break;
                case 3:
                    piratas = new List<pirata>()
                    {
                        new pirata {id = 0, posicao = 0, img = this.containerInicial.ad3Img0},
                        new pirata {id = 1, posicao = 0, img = this.containerInicial.ad3Img1},
                        new pirata {id = 2, posicao = 0, img = this.containerInicial.ad3Img2},
                        new pirata {id = 3, posicao = 0, img = this.containerInicial.ad3Img3},
                        new pirata {id = 4, posicao = 0, img = this.containerInicial.ad3Img4},
                        new pirata {id = 5, posicao = 0, img = this.containerInicial.ad3Img5},
                    };
                    break;
                case 4:
                    piratas = new List<pirata>()
                    {
                        new pirata {id = 0, posicao = 0, img = this.containerInicial.ad4Img0},
                        new pirata {id = 1, posicao = 0, img = this.containerInicial.ad4Img1},
                        new pirata {id = 2, posicao = 0, img = this.containerInicial.ad4Img2},
                        new pirata {id = 3, posicao = 0, img = this.containerInicial.ad4Img3},
                        new pirata {id = 4, posicao = 0, img = this.containerInicial.ad4Img4},
                        new pirata {id = 5, posicao = 0, img = this.containerInicial.ad4Img5},
                    };
                    break;
            }
            
            this.id = id;
        }

        public void atualizarPosicao()
        {
            string resposta = Jogo.ExibirHistorico(this.containerInicial.idPartida);

            if (this.tratamentos.ehErro(resposta)) return;

            string[] historico = this.tratamentos.stringsForArray(resposta);
            
            if (historico[historico.Length].Contains(this.id.ToString()) && historico[historico.Length] != ultimaAtt)
            {
                ultimaAtt = historico[historico.Length];

                int novaPosicao = this.tratamentos.pegarPosicao(resposta);

                if(novaPosicao == 0) { return; }

                Point posicaoXYpirata = this.getDadosDll.posicoesMapeadas.Find(p => p.posicao == novaPosicao + 1).posicaXY;

                pirata pirataAtt = piratas.Find(p => p.posicao == novaPosicao);
                pirataAtt.img.Location = posicaoXYpirata;
                pirataAtt.posicao = novaPosicao;

                piratas[pirataAtt.id] = pirataAtt;
            }
        }
    }
}
