using CartagenaServer;
using sistemaAutonomoBCCIII.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sistemaAutonomoBCCIII
{
    public class GetDadosDll
    {
        public Tratamentos tratamentos;
        public ContainerInicial containerInicial;
        public ControleCarta controleCarta;


        public struct posicaoItem 
        {
            public int posicao;
            public Point posicaXY;

            public posicaoItem(int posicao, Point posicaXY) { 
                this.posicao = posicao;
                this.posicaXY = posicaXY;
            }
        }
        public List<posicaoItem> posicoesMapeadas = new List<posicaoItem>();


        public GetDadosDll(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
            this.tratamentos = new Tratamentos();
            this.controleCarta = new ControleCarta(containerInicial);
        }

        public void ListarPartidas()
        {
            this.containerInicial.listBoxPartidas.Items.Clear();

            string resposta = Jogo.ListarPartidas("T");
            string[] partidas = this.tratamentos.stringsForArray(resposta);
            Array.Reverse(partidas);

            foreach (string partida in partidas)
                this.containerInicial.listBoxPartidas.Items.Add(partida);
        }

        public void ListarPlayers()
        {
            this.containerInicial.listBoxPlayers.Items.Clear();

            string resposta = Jogo.ListarJogadores(this.containerInicial.idPartida);
            string[] jogadores = this.tratamentos.stringsForArray(resposta);

            foreach (string jogador in jogadores)
                this.containerInicial.listBoxPlayers.Items.Add(jogador);
        }

        public void ListarMao()
        {
            string cartas = Jogo.ConsultarMao(this.containerInicial.idJogador, this.containerInicial.senhaJogador);

            if (this.tratamentos.ehErro(cartas)) return;

            this.controleCarta.setCartas(cartas);
        }

        public void GerarTabuleiro()
        {
            MessageBox.Show("Atualizei");
            int[] arrayX = { 18, 18, 18, 80, 80, 80, 80, 80, 80, 142, 142, 142, 142, 142, 142, 204, 204, 204, 204, 204, 204, 264, 264, 264, 264, 264, 264, 324, 324, 324, 324, 324, 324, 386, 386, 386 };
            int[] arrayY = { 108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78, 108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78, 108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78 };

            string resposta = Jogo.ExibirTabuleiro(this.containerInicial.idPartida);
            if (this.tratamentos.ehErro(resposta)) return;

            List<string> listaCartaTabuleiro = new List<string>(this.tratamentos.stringsForArrayVirgula(resposta));

            listaCartaTabuleiro.RemoveAt(38);
            listaCartaTabuleiro.RemoveAt(0);
            listaCartaTabuleiro.RemoveAt(0);

            int index = 0;
            foreach (string carta in listaCartaTabuleiro)
            {
                Panel picture = new Panel();
                picture.Size = new Size(picture.Width = 20, picture.Height = 22);
                picture.BackColor = Color.Beige;

                switch (carta[0])
                {
                    case 'E':
                        picture.BackgroundImage = Properties.Resources.imgCaveira;
                        break;

                    case 'F':
                        picture.BackgroundImage = Properties.Resources.imgFaca;
                        break;

                    case 'G':
                        picture.BackgroundImage = Properties.Resources.imgGarrafa;
                        break;

                    case 'C':
                        picture.BackgroundImage = Properties.Resources.imgChave;
                        break;

                    case 'T':
                        picture.BackgroundImage = Properties.Resources.imgChapeu;
                        break;

                    case 'P':
                        picture.BackgroundImage = Properties.Resources.imgPistola;
                        break;
                }

                Point posicaoXY = new Point(arrayX[index], arrayY[index]);

                int posicao = Convert.ToInt32(Regex.Replace(carta, @"[^\d]", ""));
                
                posicaoItem posicaoMap = new posicaoItem(posicao, posicaoXY);
                posicoesMapeadas.Add(posicaoMap);

                picture.Location = posicaoXY;
                this.containerInicial.panelTabuleiro.Controls.Add(picture);
                index++;
            }
        }
    }
}