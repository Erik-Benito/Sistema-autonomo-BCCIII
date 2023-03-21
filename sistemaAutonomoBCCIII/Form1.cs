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
        public string idPartida;

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
            string partida = this.listBoxPartidas.Items[this.listBoxPartidas.SelectedIndex].ToString();
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

            this.idPartida = Jogo.CriarPartida(nome, senha);

            MessageBox.Show(@"Partida Criada com sucesso ${this.idPartida}");
        }
    }
}
