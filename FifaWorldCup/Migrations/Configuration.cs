namespace FifaWorldCup.Migrations
{
    using FifaWorldCup.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FifaWorldCup.Models.FifaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FifaWorldCup.Models.FifaDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //adicionar ESTATISTICA DOS JOGADORES
            var estatisticaJ = new List<EstatisticaJ> {

            //Harry Kane
            new EstatisticaJ {Id=1, Nome="Cabeceamento", Valor=83, IndiceJogador=1 },
            new EstatisticaJ {Id=2, Nome="Pot. Remate", Valor=87, IndiceJogador=1 },
            new EstatisticaJ {Id=3, Nome="Finalização", Valor=91, IndiceJogador=1 },
            new EstatisticaJ {Id=4, Nome="Rem. Longe", Valor=85, IndiceJogador=1 },
            new EstatisticaJ {Id=5, Nome="Efeito", Valor=75, IndiceJogador=1 },
            new EstatisticaJ {Id=6, Nome="Prec. Livres", Valor=68, IndiceJogador=1 },
            new EstatisticaJ {Id=7, Nome="Penaltis", Valor=86, IndiceJogador=1 },
            new EstatisticaJ {Id=8, Nome="Remates de 1ª", Valor=77, IndiceJogador=1 },

            //Sterling
            new EstatisticaJ {Id=9, Nome="Aceleração", Valor=94, IndiceJogador=2 },
            new EstatisticaJ {Id=10, Nome="Resistência", Valor=81, IndiceJogador=2 },
            new EstatisticaJ {Id=11, Nome="Força", Valor=67, IndiceJogador=2 },
            new EstatisticaJ {Id=12, Nome="Equilibrio", Valor=92, IndiceJogador=2 },
            new EstatisticaJ {Id=13, Nome="Sprint", Valor=92, IndiceJogador=2 },
            new EstatisticaJ {Id=14, Nome="Agilidade", Valor=91, IndiceJogador=2 },
            new EstatisticaJ {Id=15, Nome="Salto", Valor=60, IndiceJogador=2 },

            //Dele Ali
            new EstatisticaJ {Id=16, Nome="Agressividade", Valor=84, IndiceJogador=3 },
            new EstatisticaJ {Id=17, Nome="Reflexos", Valor=85, IndiceJogador=3 },
            new EstatisticaJ {Id=18, Nome="Pos. Ataque", Valor=85, IndiceJogador=3 },
            new EstatisticaJ {Id=19, Nome="Interceções", Valor=67, IndiceJogador=3 },
            new EstatisticaJ {Id=20, Nome="Visão", Valor=84, IndiceJogador=3 },
            new EstatisticaJ {Id=21, Nome="Compostura", Valor=86, IndiceJogador=3 },

            //Henderson
            new EstatisticaJ {Id=22, Nome="Aceleração", Valor=73, IndiceJogador=4 },
            new EstatisticaJ {Id=23 ,Nome="Resistência", Valor=92, IndiceJogador=4 },
            new EstatisticaJ {Id=24, Nome="Força", Valor=76, IndiceJogador=4 },
            new EstatisticaJ {Id=25, Nome="Equilibrio", Valor=71, IndiceJogador=4 },
            new EstatisticaJ {Id=26, Nome="Sprint", Valor=71, IndiceJogador=4 },
            new EstatisticaJ {Id=27, Nome="Agilidade", Valor=73, IndiceJogador=4 },
            new EstatisticaJ {Id=28, Nome="Salto", Valor=81, IndiceJogador=4 },
            
            //Lingard
            new EstatisticaJ {Id=29, Nome="Aceleração", Valor=85, IndiceJogador=5 },
            new EstatisticaJ {Id=30, Nome="Resistência", Valor=82, IndiceJogador=5 },
            new EstatisticaJ {Id=31, Nome="Força", Valor=61, IndiceJogador=5 },
            new EstatisticaJ {Id=32, Nome="Equilibrio", Valor=84, IndiceJogador=5 },
            new EstatisticaJ {Id=33, Nome="Sprint", Valor=83, IndiceJogador=5 },
            new EstatisticaJ {Id=34, Nome="Agilidade", Valor=85, IndiceJogador=5 },
            new EstatisticaJ {Id=35, Nome="Salto", Valor=65, IndiceJogador=5 },

            //Young
            new EstatisticaJ {Id=36, Nome="Aceleração", Valor=80, IndiceJogador=6 },
            new EstatisticaJ {Id=37, Nome="Resistência", Valor=73, IndiceJogador=6 },
            new EstatisticaJ {Id=38, Nome="Força", Valor=62, IndiceJogador=6 },
            new EstatisticaJ {Id=39, Nome="Equilibrio", Valor=77, IndiceJogador=6 },
            new EstatisticaJ {Id=40, Nome="Sprint", Valor=78, IndiceJogador=6 },
            new EstatisticaJ {Id=41, Nome="Agilidade", Valor=81, IndiceJogador=6 },
            new EstatisticaJ {Id=42, Nome="Salto", Valor=57, IndiceJogador=6 },
            
             //Maguire
            new EstatisticaJ {Id=43, Nome="Aceleração", Valor=43, IndiceJogador=7 },
            new EstatisticaJ {Id=44, Nome="Resistência", Valor=72, IndiceJogador=7 },
            new EstatisticaJ {Id=45, Nome="Força", Valor=88, IndiceJogador=7 },
            new EstatisticaJ {Id=46, Nome="Equilibrio", Valor=56, IndiceJogador=7 },
            new EstatisticaJ {Id=47, Nome="Sprint", Valor=57, IndiceJogador=7 },
            new EstatisticaJ {Id=48, Nome="Agilidade", Valor=43, IndiceJogador=7 },
            new EstatisticaJ {Id=49, Nome="Salto", Valor=71, IndiceJogador=7 },
           
             //Stones
            new EstatisticaJ {Id=50, Nome="Aceleração", Valor=71, IndiceJogador=8 },
            new EstatisticaJ {Id=51, Nome="Resistência", Valor=79, IndiceJogador=8 },
            new EstatisticaJ {Id=52, Nome="Força", Valor=79, IndiceJogador=8 },
            new EstatisticaJ {Id=53, Nome="Equilibrio", Valor=58, IndiceJogador=8 },
            new EstatisticaJ {Id=54, Nome="Sprint", Valor=71, IndiceJogador=8 },
            new EstatisticaJ {Id=55, Nome="Agilidade", Valor=64, IndiceJogador=8 },
            new EstatisticaJ {Id=56, Nome="Salto", Valor=73, IndiceJogador=8 },

             //Walker
            new EstatisticaJ {Id=57, Nome="Aceleração", Valor=87, IndiceJogador=9 },
            new EstatisticaJ {Id=58, Nome="Resistência", Valor=90, IndiceJogador=9 },
            new EstatisticaJ {Id=59, Nome="Força", Valor=80, IndiceJogador=9 },
            new EstatisticaJ {Id=60, Nome="Equilibrio", Valor=72, IndiceJogador=9 },
            new EstatisticaJ {Id=61, Nome="Sprint", Valor=93, IndiceJogador=9 },
            new EstatisticaJ {Id=62, Nome="Agilidade", Valor=70, IndiceJogador=9 },
            new EstatisticaJ {Id=63, Nome="Salto", Valor=83, IndiceJogador=9 },

             //Trippier
            new EstatisticaJ {Id=64, Nome="Aceleração", Valor=70, IndiceJogador=10 },
            new EstatisticaJ {Id=65, Nome="Resistência", Valor=87, IndiceJogador=10 },
            new EstatisticaJ {Id=66, Nome="Força", Valor=71, IndiceJogador=10 },
            new EstatisticaJ {Id=67, Nome="Equilibrio", Valor=76, IndiceJogador=10 },
            new EstatisticaJ {Id=68, Nome="Sprint", Valor=77, IndiceJogador=10 },
            new EstatisticaJ {Id=69, Nome="Agilidade", Valor=77, IndiceJogador=10 },
            new EstatisticaJ {Id=70, Nome="Salto", Valor=74, IndiceJogador=10 },

             //PickFord
            new EstatisticaJ {Id=71, Nome="Posic.", Valor=76, IndiceJogador=11 },
            new EstatisticaJ {Id=72, Nome="Mergulho GR", Valor=77, IndiceJogador=11 },
            new EstatisticaJ {Id=73, Nome="Jogo Mãos GR", Valor=79, IndiceJogador=11 },
            new EstatisticaJ {Id=74, Nome="Jogo Pés GR", Valor=86, IndiceJogador=11 },
            new EstatisticaJ {Id=75, Nome="Reflexos GR", Valor=84, IndiceJogador=11 },


            };
            estatisticaJ.ForEach(aa => context.EstatisticaJ.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //adicionar Equipamentos
            var equipamentos = new List<Equipamentos> {

            //Inglaterra
            new Equipamentos {Id=1, Imagem="InglaterraPrin.png", Nome="Principal", idSelecao=1},
            new Equipamentos {Id=2, Imagem="InglaterraSec.png", Nome="Secundário", idSelecao=1},
            new Equipamentos {Id=3, Imagem="InglaterraGR.png", Nome="Guarda-Redes", idSelecao=1},

            //Bélgica
            new Equipamentos {Id=4, Imagem="BelgicaPrin.png", Nome="Principal", idSelecao=2},
            new Equipamentos {Id=5, Imagem="BelgicaSec.png", Nome="Secundário", idSelecao=2},
            new Equipamentos {Id=6, Imagem="BelgicaGR.png", Nome="Guarda-Redes", idSelecao=2},

            //Tunísia
            new Equipamentos {Id=7, Imagem="TunisiaPrin.png", Nome="Principal", idSelecao=3},
            new Equipamentos {Id=8, Imagem="TunisiaSec.png", Nome="Secundário", idSelecao=3},
            new Equipamentos {Id=9, Imagem="TunisiaGR.png", Nome="Guarda-Redes", idSelecao=3},

            //Panamá
            new Equipamentos {Id=10, Imagem="PanamaPrin.png", Nome="Principal", idSelecao=4},
            new Equipamentos {Id=11, Imagem="PanamaSec.png", Nome="Secundário", idSelecao=4},
            new Equipamentos {Id=12, Imagem="PanamaGR.png", Nome="Guarda-Redes", idSelecao=4},

            };
            //adicionar Equipamentos
            var jogadores = new List<Jogadores> {

            //Inglaterra
            new Jogadores {Id=1, Nome="Harry Kane", Posicao="PLE", Imagem="HarryKane.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[0], estatisticaJ[1], estatisticaJ[2], estatisticaJ[3], estatisticaJ[4], estatisticaJ[5], estatisticaJ[6], estatisticaJ[7]}},
            new Jogadores {Id=2, Nome="Sterling", Posicao="PLD", Imagem="Sterling.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[8], estatisticaJ[9], estatisticaJ[10], estatisticaJ[11], estatisticaJ[12], estatisticaJ[13], estatisticaJ[14]}},
            new Jogadores {Id=3, Nome="Dele Ali", Posicao="MCE", Imagem="DeleAli.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[15], estatisticaJ[16], estatisticaJ[17], estatisticaJ[18], estatisticaJ[19], estatisticaJ[20]}},
            new Jogadores {Id=4, Nome="Henderson", Posicao="MC", Imagem="Henderson.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[21], estatisticaJ[22], estatisticaJ[23], estatisticaJ[24], estatisticaJ[25], estatisticaJ[26], estatisticaJ[27]}},
            new Jogadores {Id=5, Nome="Lingard", Posicao="MCD", Imagem="Lingard.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[28], estatisticaJ[29], estatisticaJ[30], estatisticaJ[31], estatisticaJ[32], estatisticaJ[33], estatisticaJ[34]}},
            new Jogadores {Id=6, Nome="Young", Posicao="LEO", Imagem="Young.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[35], estatisticaJ[9], estatisticaJ[10], estatisticaJ[11], estatisticaJ[12], estatisticaJ[13], estatisticaJ[14]}},
            new Jogadores {Id=7, Nome="Dele Ali", Posicao="MCO", Imagem="DeleAli.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[15], estatisticaJ[16], estatisticaJ[17], estatisticaJ[18], estatisticaJ[19], estatisticaJ[20]}},
            new Jogadores {Id=8, Nome="Henderson", Posicao="MC", Imagem="Henderson.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[21], estatisticaJ[22], estatisticaJ[23], estatisticaJ[24], estatisticaJ[25], estatisticaJ[26], estatisticaJ[27]}},

            };
            jogadores.ForEach(aa => context.Jogadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();













            // adiciona GRUPOS
            var grupos = new List<Grupos> {
            new Grupos {Id=1, Nome="", Selecoes },
         };
            grupos.ForEach(aa => context.Grupos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
        }
    }
}
