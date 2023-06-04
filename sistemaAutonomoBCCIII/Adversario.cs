using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sistemaAutonomoBCCIII.Properties.ControlePirata;
using static sistemaAutonomoBCCIII.GetDadosDll;
using System.Runtime.InteropServices;
using System.Collections;

namespace sistemaAutonomoBCCIII
{
    public class Adversario
    {
        public ContainerInicial containerInicial;
        public GetDadosDll getDadosDll;
        public Tratamentos tratamentos = new Tratamentos();

        public int id;
        public List<pirata> piratas;
        public string ultimaAtt = "";
        public string penultimaAtt = "";


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

        private void attPirata(string ultimoItem)
        {
            int novaPosicao = this.tratamentos.pegarPosicao(ultimoItem);

            if (novaPosicao == 0) { return; }

            posicaoItem posicaoXYpirata = this.getDadosDll.posicoesMapeadas.Find(p => p.posicao == novaPosicao + 1);
            string[] partes = ultimoItem.Split(',');

            int posicaoAntiga = String.IsNullOrEmpty(partes[3]) ? 0 : Convert.ToInt32(partes[3]);

            pirata pirataAtt = piratas.Find(p => p.posicao == posicaoAntiga);

            Random random = new Random();

            posicaoXYpirata.posicaXY.X += random.Next(15, 20);

            pirataAtt.img.Location = posicaoXYpirata.posicaXY;
            pirataAtt.posicao = novaPosicao;

            this.containerInicial.panelTabuleiro.Controls.Remove(piratas[pirataAtt.id].img);
            this.containerInicial.panelTabuleiro.Controls.Add(pirataAtt.img);
            this.containerInicial.panelTabuleiro.Controls.SetChildIndex(pirataAtt.img, 0);


            piratas[pirataAtt.id] = pirataAtt;
        }

        public void atualizarPosicao(string resposta)
        {
            bool ultimaJogada = false;
            bool penultimaJogada = false;
            bool antiPenultimaJogada = false;


            if (this.tratamentos.ehErro(resposta) || String.IsNullOrEmpty(resposta)) return;

            List<string> historico = this.tratamentos.stringsForArray(resposta).ToList();
            string ultimoItem = historico.Last();


            if (historico.Count >= 3)
            {
                ultimaJogada = historico[historico.Count - 1].Contains(this.id.ToString());
                penultimaJogada = historico[historico.Count - 2].Contains(this.id.ToString());
                antiPenultimaJogada = historico[historico.Count - 3].Contains(this.id.ToString());
            }

            if (ultimaJogada == true && penultimaJogada == true && antiPenultimaJogada == true && ultimoItem != ultimaAtt)
            {
                ultimaAtt = ultimoItem;

                attPirata(historico[historico.Count - 3]);
                attPirata(historico[historico.Count - 2]);
                attPirata(historico[historico.Count - 1]);
            }
        }
    }
}
