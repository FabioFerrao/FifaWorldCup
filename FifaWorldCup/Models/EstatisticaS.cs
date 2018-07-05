using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FifaWorldCup.Models
{
    public class EstatisticaS
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Valor { get; set; }

        public int IndiceSelecao { get; set; }

    }
}