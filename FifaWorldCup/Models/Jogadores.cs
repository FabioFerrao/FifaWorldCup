using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FifaWorldCup.Models
{
    public class Jogadores
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Posicao { get; set; }

        public string Imagem { get; set; }

        public ICollection<EstatisticaJ> EstatisticaJ { get; set; }

    }
}