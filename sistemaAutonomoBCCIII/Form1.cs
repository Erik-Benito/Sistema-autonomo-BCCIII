using CartagenaServer;
using sistemaAutonomoBCCIII.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistemaAutonomoBCCIII
{
    public partial class ContainerInicial : Form
    {

        public GetDadosDll getDadosDll;
        public Tratamentos tratamentos;
        public ControleCarta controleCarta;
        public int idPartida;
        public int idJogador;
        public string senhaJogador;

        public ContainerInicial()
        {
            InitializeComponent();
            this.getDadosDll = new GetDadosDll(this);
            this.controleCarta = new ControleCarta(this);
            this.tratamentos = new Tratamentos();
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string resposta = Jogo.IniciarPartida(this.idJogador, this.senhaJogador);

            if (this.tratamentos.ehErro(resposta))
                return;


            this.getDadosDll.ListarPartidas();
            this.getDadosDll.ListarMao();
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
        }
    }
}
