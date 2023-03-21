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

            string idPartida = this.containerInicial.listBoxPartidas.Items[this.containerInicial.listBoxPartidas.SelectedIndex].ToString().Substring(0, 2);

            string resposta = Jogo.ListarJogadores(Convert.ToInt32(idPartida));
            string[] jogadores = this.tratamentos.stringsForArray(resposta);

            foreach (string jogador in jogadores)
                this.containerInicial.listBoxPlayers.Items.Add(jogador);
        }

    }
}