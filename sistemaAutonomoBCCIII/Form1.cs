using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace sistemaAutonomoBCCIII
{
    public partial class ContainerInicial : Form
    {

        public GetDadosDll getDadosDll;
        public int idPartida;
        public int idJogador;
        public string senhaJogador;

        public ContainerInicial()
        {
            InitializeComponent();
            this.getDadosDll = new GetDadosDll(this);
        }

        private void ContainerInicial_Load(object sender, EventArgs e)
        {
            this.getDadosDll.ListarPartidas();
            
        }



        private void listBoxPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPartidas_Click(object sender, EventArgs e)
        {
            this.idPartida = Convert.ToInt32(this.listBoxPartidas.Items[this.listBoxPartidas.SelectedIndex].ToString().Substring(0, 2));
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

            MessageBox.Show(@"Partida Criada com sucesso ${this.idPartida}");
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

            string[] resposta = Jogo.EntrarPartida(this.idPartida, nome, senha).Split(',');

            this.idJogador = Convert.ToInt32(resposta[0]);
            this.lblSenha.Text = "Senha:" + resposta[1];
            this.senhaJogador = resposta[1];
            this.splitterJogo.BackColor = resposta[2] == "Vermelho" ? Color.Red: Color.Green;

            MessageBox.Show(@"Entrou com sucesso ${this.idPartida}");
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(this.idJogador, this.senhaJogador);
            this.getDadosDll.ListarMao();
        }
    }
}
