using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FifaWorldCup.Models
{
    public class EstatisticaJ
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Valor { get; set; }

        public int IndiceJogador { get; set; }
    }
}