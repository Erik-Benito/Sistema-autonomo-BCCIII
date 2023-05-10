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
            try
            {
                this.containerInicial.listBoxPartidas.Items.Clear();

                string resposta = Jogo.ListarPartidas("T");

                if (this.tratamentos.ehErro(resposta)) return;

                string[] partidas = this.tratamentos.stringsForArray(resposta);
                Array.Reverse(partidas);

                foreach (string partida in partidas)
                    this.containerInicial.listBoxPartidas.Items.Add(partida);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar listar as Partidas, por favor tente novamente");
            }
        }

        public void ListarPlayers()
        {

            try
            {
                this.containerInicial.listBoxPlayers.Items.Clear();

                string resposta = Jogo.ListarJogadores(this.containerInicial.idPartida);

                if (this.tratamentos.ehErro(resposta)) return;

                string[] jogadores = this.tratamentos.stringsForArray(resposta);

                foreach (string jogador in jogadores)
                    this.containerInicial.listBoxPlayers.Items.Add(jogador);

            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar listar os jogadores, por favor tente novamente");
            }


        }

        public void ListarMao()
        {
            try
            {
                string cartas = Jogo.ConsultarMao(this.containerInicial.idJogador, this.containerInicial.senhaJogador);

                if (this.tratamentos.ehErro(cartas)) return;

                this.controleCarta.setCartas(cartas);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar listar a cartas do jogador, por favor tente novamente");
            }

        }

        public void GerarTabuleiro()
        {
            int[] arrayX = { 28, 28, 28, 105, 105, 105, 105, 105, 105, 162, 162, 162, 162, 162, 162, 234, 234, 234, 234, 234, 234, 294, 294, 294, 294, 294, 294, 368, 368, 368, 368, 368, 368, 442, 442, 442 };
            int[] arrayY = { 218, 288, 362, 362, 288, 218, 148, 78, 22, 22, 78, 148, 218, 288, 362, 362, 288, 218, 148, 78, 22, 22, 78, 148, 218, 288, 362, 362, 288, 218, 148, 78, 22, 22, 78, 148 };

            string resposta = "";

            try
            {
                resposta = Jogo.ExibirTabuleiro(this.containerInicial.idPartida);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar as cartas do tabuleiro, por favor tente novamente");
            }


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