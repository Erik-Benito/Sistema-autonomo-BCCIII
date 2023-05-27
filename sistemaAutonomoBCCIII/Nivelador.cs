using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAutonomoBCCIII
{
    internal class Nivelador
    {
        public enum situacoes
        {
            PoucaCarta,
            MuitaCarta,
            PirataAtrasado,
            PirataAvancado,
            GanhoDuasCartas,
            PiratasEmFormacao,
            AdversarioNaFormacao,
            DistanciaAlta,
            EvitarTrilha,
            VaiNaFe,
            TrilhaAdversaria,
            PularVez
        }

        public int pontos = 0;
        public List<situacoes> index = new List<situacoes>();
        public Nivelador()
        {

        }
    }
}
