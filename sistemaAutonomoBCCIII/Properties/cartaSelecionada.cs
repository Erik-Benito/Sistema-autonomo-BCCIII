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

        public int qtdCarta;
        public int qtdTricornio;
        public int qtdCaveira;
        public int qtdGarrafa;
        public int qtdFaca;
        public int qtdPistola;
        public int qtdChave;

        public ControleCarta(ContainerInicial containerInicial)
        { this.containerInicial = containerInicial; }

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
            this.containerInicial.lblCaveira.Text = this.qtdCartas(cartas, "E").ToString();
            this.containerInicial.lblFaca.Text = this.qtdCartas(cartas, "F").ToString();
            this.containerInicial.lblGarrafa.Text = this.qtdCartas(cartas, "G").ToString();
            this.containerInicial.lblPistola.Text = this.qtdCartas(cartas, "P").ToString();
            this.containerInicial.lblChave.Text = this.qtdCartas(cartas, "C").ToString();
            this.containerInicial.lblTricornio.Text = this.qtdCartas(cartas, "T").ToString();

            this.qtdTricornio = this.qtdCartas(cartas, "T"); 
            this.qtdCaveira = this.qtdCartas(cartas, "E");
            this.qtdGarrafa = this.qtdCartas(cartas, "G");
            this.qtdFaca = this.qtdCartas(cartas, "F");
            this.qtdPistola = this.qtdCartas(cartas, "P"); ;
            this.qtdChave = this.qtdCartas(cartas, "C");

            Console.WriteLine(this.qtdTricornio.ToString());
            Console.WriteLine(this.qtdCaveira.ToString());
            Console.WriteLine(this.qtdGarrafa.ToString());
            Console.WriteLine(this.qtdFaca.ToString());
            Console.WriteLine(this.qtdPistola.ToString());
            Console.WriteLine(this.qtdChave.ToString());


            this.qtdCarta = qtdCartas(cartas, "E") + this.qtdCartas(cartas, "F") + this.qtdCartas(cartas, "G") + this.qtdCartas(cartas, "P") + this.qtdCartas(cartas, "C") + this.qtdCartas(cartas, "T"); ;

        }

        public void selecionarCarta(string cartaSelecionada)
        {
            this.limparCorCartas();

            if (cartaSelecionada == this.cartaSelecionada && this.containerInicial.botOn == false)
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
