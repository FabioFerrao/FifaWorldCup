using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FifaWorldCup.Models
{
    public class FifaDB : DbContext
    {

        // construtor da classe
        public FifaDB() : base("FifaDBConnectionString"){ }

        // identificar as tabelas da base de dados
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Selecoes> Selecoes { get; set; }
        public virtual DbSet<Jogadores> Jogadores { get; set; }
        public virtual DbSet<Equipamentos> Equipamentos { get; set; }
        public virtual DbSet<EstatisticaS> EstatisticaS { get; set; }
        public virtual DbSet<EstatisticaJ> EstatisticaJ { get; set; }



        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder"> objeto que referencia o gerador de base de dados </param>      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}