using CartagenaServer;
using sistemaAutonomoBCCIII.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;

namespace sistemaAutonomoBCCIII
{
    public partial class ContainerInicial : Form
    {

        public GetDadosDll getDadosDll;
        public Tratamentos tratamentos;
        public ControleCarta controleCarta;
        public ControlePirata controlePirata;
        public int idPartida;
        public int idJogador;
        public string senhaJogador;
        public string[] posicicoes;
        public string pirataEscolhido;

        public ContainerInicial()
        {
            InitializeComponent();
            this.getDadosDll = new GetDadosDll(this);
            this.controleCarta = new ControleCarta(this);
            this.tratamentos = new Tratamentos();
            this.controlePirata = new ControlePirata(this);
        }

        private void ContainerInicial_Load(object sender, EventArgs e)
        {
            this.getDadosDll.ListarPartidas();
        }

        private void listBoxPartidas_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listBoxPartidas_Click(object sender, EventArgs e)
        {
            this.idPartida = this.tratamentos.getIdString(this.listBoxPartidas.Items[this.listBoxPartidas.SelectedIndex].ToString());
            this.getDadosDll.ListarPlayers();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = this.txtNomePartida.Text;
            string senha = this.txtSenhaPartida.Text;

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Deve ser preenchido com um nome valido a partida!");
                return;
            }

            if (String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Deve ser preenchido com uma senha valido a partida!");
                return;
            }

            this.idPartida = Convert.ToInt32(Jogo.CriarPartida(nome, senha));

            this.getDadosDll.ListarPartidas();
            MessageBox.Show($"Partida Criada com sucesso {this.idPartida}");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtPirata.Text;
            string senha = this.txtSenhaPirata.Text;

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Deve ser preenchido com um nome valido de pirata!");
                return;
            }

            if (String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Deve ser preenchido com uma senha valido a senha!");
                return;
            }

            string resposta = Jogo.EntrarPartida(this.idPartida, nome, senha);
            
            if (this.tratamentos.ehErro(resposta))
                return;

            string[] dados = resposta.Split(',');
            this.idJogador = Convert.ToInt32(dados[0]);
            this.lblSenha.Text = "Senha:" + dados[1];
            this.senhaJogador = dados[1];
            this.splitterJogo.BackColor = dados[2] == "vermelho" ? Color.Red : Color.Red;

            MessageBox.Show($"Entrou com sucesso {this.idPartida}");
        }

        private void lblSenha_Click(object sender, EventArgs e) { }

        public void GerarTabuleiro()
        {
            string casaPos = Jogo.ExibirTabuleiro(this.idPartida);

            Panel panel = this.Controls.Find("panelTabuleiro", true).FirstOrDefault() as Panel;

            int[] arrayX = {18, 18, 18, 80, 80, 80, 80, 80, 80, 142, 142, 142, 142, 142, 142, 204, 204, 204, 204, 204, 204, 264, 264, 264, 264, 264, 264, 324, 324, 324, 324, 324, 324, 386, 386, 386};
            int[] arrayY = {108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78, 108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78, 108, 138, 168, 168, 138, 108, 78, 48, 18, 18, 48, 78};

            string[] casaTabuleiro = Jogo.ExibirTabuleiro(this.idPartida).Replace("\r\n", "").Split(',');
            int length = casaTabuleiro.Length;

            List<string> listaCasaTabuleiro = new List<string>(casaTabuleiro);

            listaCasaTabuleiro.RemoveAt(38);
            listaCasaTabuleiro.RemoveAt(0);
            listaCasaTabuleiro.RemoveAt(0);

            for (int i = 0; i < listaCasaTabuleiro.Count; i++)
            {
                string casa = listaCasaTabuleiro[i][0].ToString();

                Panel picture = new Panel();

                picture.Size = new Size(picture.Width = 20, picture.Height = 22);
                picture.BackColor = Color.Beige;

                switch (casa)
                {
                    case "E":
                        picture.BackgroundImage = Properties.Resources.imgCaveira;
                        break;

                    case "F":
                        picture.BackgroundImage = Properties.Resources.imgFaca;
                        break;

                    case "G":
                        picture.BackgroundImage = Properties.Resources.imgGarrafa;
                        break;

                    case "C":
                        picture.BackgroundImage = Properties.Resources.imgChave;
                        break;

                    case "T":
                        picture.BackgroundImage = Properties.Resources.imgChapeu;
                        break;

                    case "P":
                        picture.BackgroundImage = Properties.Resources.imgPistola;
                        break;
                }

                picture.Location = new Point(arrayX[i], arrayY[i]);
                panel.Controls.Add(picture);
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string resposta = Jogo.IniciarPartida(this.idJogador, this.senhaJogador);

            if (this.tratamentos.ehErro(resposta))
                return;

            this.getDadosDll.ListarPartidas();
            this.getDadosDll.ListarMao();
            this.getDadosDll.ListarPosicao();
            GerarTabuleiro();
        }

        private void cartaTricornio_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("T");
        }

        private void cartaFaca_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("F");
        }

        private void cartaPistola_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("P");
        }

        private void cartaChave_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("C");
        }

        private void cartaEsqueleto_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("E");
        }

        private void cartaGarrafa_Click(object sender, EventArgs e)
        {
            this.controleCarta.selecionarCarta("G");
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Console.WriteLine( this.controlePirata.SelecionarPirata(this.controlePirata.pirataSelecionado));
            Jogo.Jogar(this.idJogador, this.senhaJogador, this.controlePirata.SelecionarPirata(this.controlePirata.pirataSelecionado), this.controleCarta.cartaSelecionada);
            this.controlePirata.SetPosicao(this.controlePirata.pirataSelecionado, this.getDadosDll.PosicaoPirata());
            Console.WriteLine(Jogo.ExibirHistorico(this.idPartida));
            this.getDadosDll.ListarPosicao();
        }

        private void listBoxPosicoes_SelectedIndexChanged(object sender, EventArgs e){}

        private void txtPirataEscolhido_TextChanged(object sender, EventArgs e)
        {
            this.pirataEscolhido = this.txtPirataEscolhido.Text;
        }

        private void listBoxPiratas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controlePirata.pirataSelecionado = this.listBoxPiratas1.SelectedIndex;
            Console.WriteLine(this.controlePirata.pirataSelecionado);
        }

        private void lblCaveira_Click(object sender, EventArgs e)
        {

        }

        private void lblGarrafa_Click(object sender, EventArgs e)
        {

        }

    }
}
