using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAutonomoBCCIII.Properties
{
    public class ControleCarta
    {
        public ContainerInicial containerInicial;
        // @ para indicar para que o não há um carta selecionado, desculpe mas esse é o padrão do codigo do professor.
        public string cartaSelecionada = "@";

        public int qtdTricornio;
        public int qtdCaveira;
        public int qtdGarrafa;
        public int qtdFaca;
        public int qtdPistola;
        public int qtdChave;
        public ControleCarta(ContainerInicial containerInicial)
        { this.containerInicial = containerInicial; }

        public int qtdDeCarta()
        {
            int qntcartas = qtdTricornio + qtdCaveira + qtdGarrafa + qtdFaca + qtdPistola + qtdChave;

            return qntcartas;
        }

        private void qtdPorCarta(int tricornio, int caveira, int garrafa, int faca, int pistola, int chave)
        {
            this.qtdTricornio = tricornio;
            this.qtdCaveira = caveira;
            this.qtdGarrafa = garrafa;
            this.qtdFaca = faca;
            this.qtdPistola = pistola;
            this.qtdChave = chave;
        }

        private void limparCorCartas()
        {
            this.containerInicial.lblGarrafa.BackColor = Color.Beige;
            this.containerInicial.lblPistola.BackColor = Color.Beige;
            this.containerInicial.lblTricornio.BackColor = Color.Beige;
            this.containerInicial.lblCaveira.BackColor = Color.Beige;
            this.containerInicial.lblChave.BackColor = Color.Beige;
            this.containerInicial.lblFaca.BackColor = Color.Beige;
        }

        private int qtdCartas(string cartas, string cartaProcurada)
        {
            int posicaoCarta = cartas.IndexOf(cartaProcurada);

            if (posicaoCarta == -1) return 0;

            return Convert.ToInt32(cartas.Substring(posicaoCarta + 2, 1));
        }

        public void setCartas(string cartas)
        {
            qtdPorCarta(this.qtdCartas(cartas, "T"), this.qtdCartas(cartas, "C"), this.qtdCartas(cartas, "G"), this.qtdCartas(cartas, "F"), this.qtdCartas(cartas, "P"), this.qtdCartas(cartas, "C"));

            this.containerInicial.lblCaveira.Text = qtdCaveira.ToString();
            this.containerInicial.lblFaca.Text = qtdFaca.ToString();
            this.containerInicial.lblGarrafa.Text = qtdGarrafa.ToString();
            this.containerInicial.lblPistola.Text = qtdPistola.ToString();
            this.containerInicial.lblChave.Text = qtdChave.ToString();
            this.containerInicial.lblTricornio.Text = qtdTricornio.ToString();

        }

        public void selecionarCarta(string cartaSelecionada)
        {
            this.limparCorCartas();

            if (cartaSelecionada == this.cartaSelecionada)
            {
                this.cartaSelecionada = "@";
                return;
            }
            
            this.cartaSelecionada = cartaSelecionada;

            switch (this.cartaSelecionada)
            {
                case "G":
                    this.containerInicial.lblGarrafa.BackColor = Color.Blue;
                    break;
                case "P":
                    this.containerInicial.lblPistola.BackColor = Color.Blue;
                    break;
                case "T":
                    this.containerInicial.lblTricornio.BackColor = Color.Blue;
                    break;
                case "E":
                    this.containerInicial.lblCaveira.BackColor = Color.Blue;
                    break;
                case "F":
                    this.containerInicial.lblFaca.BackColor = Color.Blue;
                    break;
                case "C":
                    this.containerInicial.lblChave.BackColor = Color.Blue;
                    break;

                default:
                    break;
            }
        }


    }
}
