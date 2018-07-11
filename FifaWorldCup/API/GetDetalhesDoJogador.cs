using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FifaWorldCup.API
{
    public class GetDetalhesDoJogador
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public string Imagem { get; set; }

        public ICollection<EstatisticaDoJogador> listaDeEstatisticaPorJogador { get; set; }

        public class EstatisticaDoJogador
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Valor { get; set; }
        }

    }
}