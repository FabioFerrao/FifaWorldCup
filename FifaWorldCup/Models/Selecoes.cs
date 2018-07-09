using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FifaWorldCup.Models
{
    public class Selecoes
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Emblema { get; set; }

        public ICollection<Jogadores> Jogadores { get; set; }

        public ICollection<Equipamentos> Equipamentos { get; set; }

        public ICollection<EstatisticaS> EstatisticaS { get; set; }

        [ForeignKey("Grupos")]
        public int IndideGrupo { get; set; }
        public virtual Grupos Grupos { get; set; }

    }
}