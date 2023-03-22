using CartagenaServer;
using System;

namespace sistemaAutonomoBCCIII
{
    public class GetDadosDll
    {
        public Tratamentos tratamentos;
        public ContainerInicial containerInicial;

        private int qtdCartas(string cartas, string cartaProcurada)
        {
            int posicaoCarta = cartas.IndexOf(cartaProcurada);

            if (posicaoCarta == -1) return 0;

            return Convert.ToInt32(cartas.Substring(posicaoCarta + 2, 1));
        }

        public GetDadosDll(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
            this.tratamentos = new Tratamentos();
        }

        public void ListarPartidas()
        {
            this.containerInicial.listBoxPartidas.Items.Clear();

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
            string cartas = Jogo.ConsultarMao(this.containerInicial.idJogador, this.containerInicial.senhaJogador);

            if (this.tratamentos.ehErro(cartas))
                return;

            this.containerInicial.lblCaveira.Text = this.qtdCartas(cartas, "E").ToString();
            this.containerInicial.lblFaca.Text = this.qtdCartas(cartas, "F").ToString();
            this.containerInicial.lblGarrafa.Text = this.qtdCartas(cartas, "G").ToString();
            this.containerInicial.lblPistola.Text = this.qtdCartas(cartas, "P").ToString();
            this.containerInicial.lblChave.Text = this.qtdCartas(cartas, "T").ToString();
        }
    }
}