using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAutonomoBCCIII
{
    internal class Validador
    {
        Nivelador seguro;
        Nivelador moderado;
        Nivelador arriscado;
        ContainerInicial containerInicial;


        public Validador(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
        }
        public void PoucaCarta(int qtdcartas)
        {
            if(qtdcartas <= 3 )
            {
                arriscado.pontos++;
                arriscado.index.Add(Nivelador.situacoes.PoucaCarta); 
            }
        }

        public void MuitaCarta(int qtdcartas)
        {
            if(qtdcartas >= 3 && qtdcartas <= 5) 
            {
                moderado.pontos++;
                moderado.index.Add(Nivelador.situacoes.MuitaCarta);
            }
            else if(qtdcartas > 5)
            {
                seguro.pontos++;
                seguro.index.Add(Nivelador.situacoes.MuitaCarta);
            }
        }

        public void PirataAtrasado()
        {
            int ultPirata = 0;
            int primPirata = 0;

            this.containerInicial.controlePirata.piratas.ForEach(pirata => { 
                if (pirata.posicao < ultPirata) { 
                    ultPirata = pirata.posicao;
                } 
            });

            this.containerInicial.adversario1.piratas.ForEach((pirata) =>
            {
                if(pirata.posicao > primPirata)
                {
                    primPirata = pirata.posicao;
                }
            });

            this.containerInicial.adversario2.piratas.ForEach((pirata) =>
            {
                if (pirata.posicao > primPirata)
                {
                    primPirata = pirata.posicao;
                }
            });

            this.containerInicial.adversario3.piratas.ForEach((pirata) =>
            {
                if (pirata.posicao > primPirata)
                {
                    primPirata = pirata.posicao;
                }
            });

            this.containerInicial.adversario4.piratas.ForEach((pirata) =>
            {
                if (pirata.posicao > primPirata)
                {
                    primPirata = pirata.posicao;
                }
            });

            this.containerInicial.controlePirata.piratas.ForEach(pirata => {
                if (pirata.posicao > primPirata)
                {
                    ultPirata = pirata.posicao;
                }
            });

            if (primPirata - ultPirata > 18)
            {
                arriscado.pontos++;
                arriscado.index.Add(Nivelador.situacoes.PirataAtrasado);

            } else if(primPirata - ultPirata > 9 && primPirata - ultPirata < 18)
            {
                arriscado.pontos++;
                arriscado.index.Add(Nivelador.situacoes.PirataAtrasado);
            } else
            {
                seguro.pontos++;
            }
        }

        public void PirataAvancado()
        {

        }
    }
}
