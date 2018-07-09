using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Selecoes")]
        public int IndiceSelecao { get; set; }
        public virtual Selecoes Selecoes { get; set; }

    }
}