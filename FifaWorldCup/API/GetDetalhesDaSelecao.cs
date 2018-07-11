using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FifaWorldCup.API
{
    public class GetDetalhesDaSelecao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Emblema { get; set; }

        public ICollection<JogadoresDaSelecao> listaDeJogadoresPorSelecao { get; set; }

        public class JogadoresDaSelecao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Imagem { get; set; }
            public string Posicao { get; set; }

        }
        public ICollection<EstatisticaDaSelecao> listaDeEstatisticaPorSelecao { get; set; }

        public class EstatisticaDaSelecao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Valor { get; set; }
        }
        public ICollection<EquipamentosDaSelecao> listaDeEquipamentosPorSelecao { get; set; }

        public class EquipamentosDaSelecao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Imagem { get; set; }
        }
    }
}