using CartagenaServer;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace sistemaAutonomoBCCIII
{
    public class GetDadosDll
    {
        public Tratamentos tratamentos;
        public ContainerInicial containerInicial;

        public GetDadosDll(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
            this.tratamentos = new Tratamentos();
        }

        public void ListarPartidas()
        {
            string resposta = Jogo.ListarPartidas("T");
            string[] partidas = this.tratamentos.stringsForArray(resposta);

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
            string resposta = Jogo.ConsultarMao(this.containerInicial.idJogador, this.containerInicial.senhaJogador);
            resposta.Replace("\r", "");
            string[] cartas = resposta.Split('\n');
            if(cartas[0] != null)
                this.containerInicial.lblCaveira.Text = cartas[0].Substring(2,1);
            if (cartas[1] != null)
                this.containerInicial.lblFaca.Text = cartas[1].Substring(2, 1);
            if (cartas[2] != null)
                this.containerInicial.lblGarrafa.Text = cartas[2].Substring(2, 1);
            if (cartas[3] != null)
                this.containerInicial.lblPistola.Text = cartas[3].Substring(2, 1);
            if (cartas[4] != null)
                this.containerInicial.lblChave.Text = cartas[4].Substring(1, 1);

        }
    }
}