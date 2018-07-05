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

            //adicionar ESTATISTICA DOS JOGADORES
            var estatisticaJ = new List<EstatisticaJ> {
            
                
            //---------------------------  INGLATERRA --------------------------------



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


            //---------------------------  BELGICA --------------------------------


             //Lukaku
            new EstatisticaJ {Id=76, Nome="Aceleração", Valor=76, IndiceJogador=12 },
            new EstatisticaJ {Id=77, Nome="Resistência", Valor=80, IndiceJogador=12 },
            new EstatisticaJ {Id=78, Nome="Força", Valor=93, IndiceJogador=12 },
            new EstatisticaJ {Id=79, Nome="Equilibrio", Valor=47, IndiceJogador=12 },
            new EstatisticaJ {Id=80, Nome="Sprint", Valor=89, IndiceJogador=12 },
            new EstatisticaJ {Id=81, Nome="Agilidade", Valor=62, IndiceJogador=12 },
            new EstatisticaJ {Id=82, Nome="Salto", Valor=71, IndiceJogador=12 },

             //Hazard
            new EstatisticaJ {Id=83, Nome="Aceleração", Valor=93, IndiceJogador=13 },
            new EstatisticaJ {Id=84, Nome="Resistência", Valor=81, IndiceJogador=13 },
            new EstatisticaJ {Id=85, Nome="Força", Valor=67, IndiceJogador=13 },
            new EstatisticaJ {Id=86, Nome="Equilibrio", Valor=93, IndiceJogador=13 },
            new EstatisticaJ {Id=87, Nome="Sprint", Valor=88, IndiceJogador=13 },
            new EstatisticaJ {Id=88, Nome="Agilidade", Valor=93, IndiceJogador=13 },
            new EstatisticaJ {Id=89, Nome="Salto", Valor=59, IndiceJogador=13 },

             //Mertens
            new EstatisticaJ {Id=90, Nome="Aceleração", Valor=93, IndiceJogador=14 },
            new EstatisticaJ {Id=91, Nome="Resistência", Valor=77, IndiceJogador=14 },
            new EstatisticaJ {Id=92, Nome="Força", Valor=42, IndiceJogador=14 },
            new EstatisticaJ {Id=93, Nome="Equilibrio", Valor=92, IndiceJogador=14 },
            new EstatisticaJ {Id=94, Nome="Sprint", Valor=87, IndiceJogador=14 },
            new EstatisticaJ {Id=95, Nome="Agilidade", Valor=94, IndiceJogador=14 },
            new EstatisticaJ {Id=96, Nome="Salto", Valor=60, IndiceJogador=14 },
            
             //Carrasco
            new EstatisticaJ {Id=97, Nome="Aceleração", Valor=86, IndiceJogador=15 },
            new EstatisticaJ {Id=98, Nome="Resistência", Valor=74, IndiceJogador=15 },
            new EstatisticaJ {Id=99, Nome="Força", Valor=60, IndiceJogador=15 },
            new EstatisticaJ {Id=100, Nome="Equilibrio", Valor=71, IndiceJogador=15 },
            new EstatisticaJ {Id=101, Nome="Sprint", Valor=88, IndiceJogador=15 },
            new EstatisticaJ {Id=102, Nome="Agilidade", Valor=91, IndiceJogador=15 },
            new EstatisticaJ {Id=103, Nome="Salto", Valor=68, IndiceJogador=15 },
            
             //Witsel
            new EstatisticaJ {Id=104, Nome="Aceleração", Valor=67, IndiceJogador=16 },
            new EstatisticaJ {Id=105, Nome="Resistência", Valor=88, IndiceJogador=16 },
            new EstatisticaJ {Id=106, Nome="Força", Valor=78, IndiceJogador=16 },
            new EstatisticaJ {Id=107, Nome="Equilibrio", Valor=60, IndiceJogador=16 },
            new EstatisticaJ {Id=108, Nome="Sprint", Valor=74, IndiceJogador=16 },
            new EstatisticaJ {Id=109, Nome="Agilidade", Valor=76, IndiceJogador=16 },
            new EstatisticaJ {Id=110, Nome="Salto", Valor=72, IndiceJogador=16 },
            
             //De Bruyne
            new EstatisticaJ {Id=111, Nome="Cabeceamento", Valor=54, IndiceJogador=17 },
            new EstatisticaJ {Id=112, Nome="Pot. Remate", Valor=87, IndiceJogador=17 },
            new EstatisticaJ {Id=113, Nome="Finalização", Valor=83, IndiceJogador=17 },
            new EstatisticaJ {Id=114, Nome="Rem. Longe", Valor=89, IndiceJogador=17 },
            new EstatisticaJ {Id=115, Nome="Efeito", Valor=85, IndiceJogador=17 },
            new EstatisticaJ {Id=116, Nome="Prec. Livres", Valor=83, IndiceJogador=17 },
            new EstatisticaJ {Id=117, Nome="Penaltis", Valor=77, IndiceJogador=17 },
            new EstatisticaJ {Id=118, Nome="Remates de 1ª", Valor=8, IndiceJogador=17 },
            
             //Meunier
            new EstatisticaJ {Id=119, Nome="Aceleração", Valor=72, IndiceJogador=18 },
            new EstatisticaJ {Id=120, Nome="Resistência", Valor=92, IndiceJogador=18 },
            new EstatisticaJ {Id=121, Nome="Força", Valor=85, IndiceJogador=18 },
            new EstatisticaJ {Id=122, Nome="Equilibrio", Valor=49, IndiceJogador=18 },
            new EstatisticaJ {Id=123, Nome="Sprint", Valor=80, IndiceJogador=18 },
            new EstatisticaJ {Id=124, Nome="Agilidade", Valor=63, IndiceJogador=18 },
            new EstatisticaJ {Id=125, Nome="Salto", Valor=72, IndiceJogador=18 },
                
             //Vertonghen
            new EstatisticaJ {Id=126, Nome="Aceleração", Valor=68, IndiceJogador=19 },
            new EstatisticaJ {Id=127, Nome="Resistência", Valor=79, IndiceJogador=19 },
            new EstatisticaJ {Id=128, Nome="Força", Valor=82, IndiceJogador=19 },
            new EstatisticaJ {Id=129, Nome="Equilibrio", Valor=55, IndiceJogador=19 },
            new EstatisticaJ {Id=130, Nome="Sprint", Valor=72, IndiceJogador=19 },
            new EstatisticaJ {Id=131, Nome="Agilidade", Valor=62, IndiceJogador=19 },
            new EstatisticaJ {Id=132, Nome="Salto", Valor=82, IndiceJogador=19 },

             //Kompany
            new EstatisticaJ {Id=133, Nome="Aceleração", Valor=59, IndiceJogador=20 },
            new EstatisticaJ {Id=134, Nome="Resistência", Valor=70, IndiceJogador=20 },
            new EstatisticaJ {Id=135, Nome="Força", Valor=87, IndiceJogador=20 },
            new EstatisticaJ {Id=136, Nome="Equilibrio", Valor=42, IndiceJogador=20 },
            new EstatisticaJ {Id=137, Nome="Sprint", Valor=62, IndiceJogador=20 },
            new EstatisticaJ {Id=138, Nome="Agilidade", Valor=59, IndiceJogador=20 },
            new EstatisticaJ {Id=139, Nome="Salto", Valor=70, IndiceJogador=20 },

            //Alderweireld
            new EstatisticaJ {Id=140, Nome="Aceleração", Valor=63, IndiceJogador=21 },
            new EstatisticaJ {Id=141, Nome="Resistência", Valor=74, IndiceJogador=21 },
            new EstatisticaJ {Id=142, Nome="Força", Valor=81, IndiceJogador=21 },
            new EstatisticaJ {Id=143, Nome="Equilibrio", Valor=50, IndiceJogador=21 },
            new EstatisticaJ {Id=144, Nome="Sprint", Valor=66, IndiceJogador=21 },
            new EstatisticaJ {Id=145, Nome="Agilidade", Valor=60, IndiceJogador=21 },
            new EstatisticaJ {Id=146, Nome="Salto", Valor=78, IndiceJogador=21 },

            //Courtois
            new EstatisticaJ {Id=147, Nome="Posic.", Valor=86, IndiceJogador=22 },
            new EstatisticaJ {Id=148, Nome="Mergulho GR", Valor=85, IndiceJogador=22 },
            new EstatisticaJ {Id=149, Nome="Jogo Mãos GR", Valor=91, IndiceJogador=22 },
            new EstatisticaJ {Id=150, Nome="Jogo Pés GR", Valor=72, IndiceJogador=22 },
            new EstatisticaJ {Id=151, Nome="Reflexos GR", Valor=88, IndiceJogador=22 },

            
            //---------------------------  TUNISIA --------------------------------

            //Khazri
            new EstatisticaJ {Id=152, Nome="Aceleração", Valor=74, IndiceJogador=23 },
            new EstatisticaJ {Id=153, Nome="Resistência", Valor=74, IndiceJogador=23 },
            new EstatisticaJ {Id=154, Nome="Força", Valor=68, IndiceJogador=23 },
            new EstatisticaJ {Id=155, Nome="Equilibrio", Valor=67, IndiceJogador=23 },
            new EstatisticaJ {Id=156, Nome="Sprint", Valor=77, IndiceJogador=23 },
            new EstatisticaJ {Id=157, Nome="Agilidade", Valor=80, IndiceJogador=23 },
            new EstatisticaJ {Id=158, Nome="Salto", Valor=44, IndiceJogador=23 },

            //Badri
            new EstatisticaJ {Id=159, Nome="Aceleração", Valor=83, IndiceJogador=24 },
            new EstatisticaJ {Id=160, Nome="Resistência", Valor=62, IndiceJogador=24 },
            new EstatisticaJ {Id=161, Nome="Força", Valor=58, IndiceJogador=24 },
            new EstatisticaJ {Id=162, Nome="Equilibrio", Valor=74, IndiceJogador=24 },
            new EstatisticaJ {Id=163, Nome="Sprint", Valor=78, IndiceJogador=24 },
            new EstatisticaJ {Id=164, Nome="Agilidade", Valor=76, IndiceJogador=24 },
            new EstatisticaJ {Id=165, Nome="Salto", Valor=69, IndiceJogador=24 },

            //Khaoui
            new EstatisticaJ {Id=166, Nome="Aceleração", Valor=69, IndiceJogador=25 },
            new EstatisticaJ {Id=167, Nome="Resistência", Valor=38, IndiceJogador=25 },
            new EstatisticaJ {Id=168, Nome="Força", Valor=49, IndiceJogador=25 },
            new EstatisticaJ {Id=169, Nome="Equilibrio", Valor=69, IndiceJogador=25 },
            new EstatisticaJ {Id=170, Nome="Sprint", Valor=70, IndiceJogador=25 },
            new EstatisticaJ {Id=171, Nome="Agilidade", Valor=76, IndiceJogador=25 },
            new EstatisticaJ {Id=172, Nome="Salto", Valor=60, IndiceJogador=25 },

            //Sassi
            new EstatisticaJ {Id=173, Nome="Aceleração", Valor=76, IndiceJogador=26 },
            new EstatisticaJ {Id=174, Nome="Resistência", Valor=76, IndiceJogador=26 },
            new EstatisticaJ {Id=175, Nome="Força", Valor=64, IndiceJogador=26 },
            new EstatisticaJ {Id=176, Nome="Equilibrio", Valor=69, IndiceJogador=26 },
            new EstatisticaJ {Id=177, Nome="Sprint", Valor=70, IndiceJogador=26 },
            new EstatisticaJ {Id=178, Nome="Agilidade", Valor=65, IndiceJogador=26 },
            new EstatisticaJ {Id=179, Nome="Salto", Valor=72, IndiceJogador=26},

            //Fakhereedine Ben Youssef
            new EstatisticaJ {Id=180, Nome="Aceleração", Valor=58, IndiceJogador=27 },
            new EstatisticaJ {Id=181, Nome="Resistência", Valor=70, IndiceJogador=27 },
            new EstatisticaJ {Id=182, Nome="Força", Valor=87, IndiceJogador=27 },
            new EstatisticaJ {Id=183, Nome="Equilibrio", Valor=48, IndiceJogador=27 },
            new EstatisticaJ {Id=184, Nome="Sprint", Valor=67, IndiceJogador=27 },
            new EstatisticaJ {Id=185, Nome="Agilidade", Valor=52, IndiceJogador=27 },
            new EstatisticaJ {Id=186, Nome="Salto", Valor=65, IndiceJogador=27},

            //Skhiri
            new EstatisticaJ {Id=187, Nome="Aceleração", Valor=68, IndiceJogador=28 },
            new EstatisticaJ {Id=188, Nome="Resistência", Valor=76, IndiceJogador=28 },
            new EstatisticaJ {Id=189, Nome="Força", Valor=68, IndiceJogador=28 },
            new EstatisticaJ {Id=190, Nome="Equilibrio", Valor=64, IndiceJogador=28},
            new EstatisticaJ {Id=191, Nome="Sprint", Valor=69, IndiceJogador=28 },
            new EstatisticaJ {Id=192, Nome="Agilidade", Valor=74, IndiceJogador=28 },
            new EstatisticaJ {Id=193, Nome="Salto", Valor=75, IndiceJogador=28},

            //Maâloul
            new EstatisticaJ {Id=194, Nome="Aceleração", Valor=86, IndiceJogador=29 },
            new EstatisticaJ {Id=195, Nome="Resistência", Valor=71, IndiceJogador=29 },
            new EstatisticaJ {Id=196, Nome="Força", Valor=45, IndiceJogador=29 },
            new EstatisticaJ {Id=197, Nome="Equilibrio", Valor=75, IndiceJogador=29},
            new EstatisticaJ {Id=198, Nome="Sprint", Valor=78, IndiceJogador=29 },
            new EstatisticaJ {Id=199, Nome="Agilidade", Valor=73, IndiceJogador=29 },
            new EstatisticaJ {Id=200, Nome="Salto", Valor=58, IndiceJogador=29},
            
            //Meriah
            new EstatisticaJ {Id=201, Nome="Aceleração", Valor=60, IndiceJogador=30 },
            new EstatisticaJ {Id=202, Nome="Resistência", Valor=62, IndiceJogador=30 },
            new EstatisticaJ {Id=203, Nome="Força", Valor=71, IndiceJogador=30 },
            new EstatisticaJ {Id=204, Nome="Equilibrio", Valor=58, IndiceJogador=30},
            new EstatisticaJ {Id=205, Nome="Sprint", Valor=63, IndiceJogador=30 },
            new EstatisticaJ {Id=206, Nome="Agilidade", Valor=61, IndiceJogador=30 },
            new EstatisticaJ {Id=207, Nome="Salto", Valor=76, IndiceJogador=30},
            
            //Syam Ben Youssef
            new EstatisticaJ {Id=208, Nome="Aceleração", Valor=60, IndiceJogador=31 },
            new EstatisticaJ {Id=209, Nome="Resistência", Valor=73, IndiceJogador=31 },
            new EstatisticaJ {Id=210, Nome="Força", Valor=86, IndiceJogador=31 },
            new EstatisticaJ {Id=211, Nome="Equilibrio", Valor=45, IndiceJogador=31},
            new EstatisticaJ {Id=212, Nome="Sprint", Valor=65, IndiceJogador=31 },
            new EstatisticaJ {Id=213, Nome="Agilidade", Valor=32, IndiceJogador=31 },
            new EstatisticaJ {Id=214, Nome="Salto", Valor=82, IndiceJogador=31},

            //Bronn
            new EstatisticaJ {Id=215, Nome="Aceleração", Valor=69, IndiceJogador=32 },
            new EstatisticaJ {Id=216, Nome="Resistência", Valor=73, IndiceJogador=32 },
            new EstatisticaJ {Id=217, Nome="Força", Valor=72, IndiceJogador=32 },
            new EstatisticaJ {Id=218, Nome="Equilibrio", Valor=63, IndiceJogador=32},
            new EstatisticaJ {Id=219, Nome="Sprint", Valor=67, IndiceJogador=32 },
            new EstatisticaJ {Id=220, Nome="Agilidade", Valor=61, IndiceJogador=32 },
            new EstatisticaJ {Id=221, Nome="Salto", Valor=68, IndiceJogador=32},

            //Ben Mustapha
            new EstatisticaJ {Id=222, Nome="Posic.", Valor=70, IndiceJogador=33 },
            new EstatisticaJ {Id=223, Nome="Mergulho GR", Valor=68, IndiceJogador=33 },
            new EstatisticaJ {Id=224, Nome="Jogo Mãos GR", Valor=67, IndiceJogador=33 },
            new EstatisticaJ {Id=225, Nome="Jogo Pés GR", Valor=59, IndiceJogador=33 },
            new EstatisticaJ {Id=226, Nome="Reflexos GR", Valor=63, IndiceJogador=33 },



            };
            estatisticaJ.ForEach(aa => context.EstatisticaJ.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //adicionar estatistica das selecoes
            var estatisticaS = new List<EstatisticaS> {

                //Inglaterra
                new EstatisticaS {Id=1, Nome="Ataque", Valor="83", IndiceSelecao=1 },
                new EstatisticaS {Id=2, Nome="Meio-Campo", Valor="81", IndiceSelecao=1 },
                new EstatisticaS {Id=3, Nome="Defesa", Valor="80", IndiceSelecao=1 },
                new EstatisticaS {Id=4, Nome="Capitão", Valor="Harry Kane", IndiceSelecao=1 },
                new EstatisticaS {Id=5, Nome="Avaliação Geral", Valor="4,5", IndiceSelecao=1 },

                //Belgica
                new EstatisticaS {Id=6, Nome="Ataque", Valor="85", IndiceSelecao=2 },
                new EstatisticaS {Id=7, Nome="Meio-Campo", Valor="83", IndiceSelecao=2 },
                new EstatisticaS {Id=8, Nome="Defesa", Valor="83", IndiceSelecao=2 },
                new EstatisticaS {Id=9, Nome="Capitão", Valor="Hazard", IndiceSelecao=2 },
                new EstatisticaS {Id=10, Nome="Avaliação Geral", Valor="5", IndiceSelecao=2 },

                //Tunisia
                new EstatisticaS {Id=11, Nome="Ataque", Valor="75", IndiceSelecao=3 },
                new EstatisticaS {Id=12, Nome="Meio-Campo", Valor="71", IndiceSelecao=3 },
                new EstatisticaS {Id=13, Nome="Defesa", Valor="71", IndiceSelecao=3 },
                new EstatisticaS {Id=14, Nome="Capitão", Valor="Khazri", IndiceSelecao=3 },
                new EstatisticaS {Id=15, Nome="Avaliação Geral", Valor="3,5", IndiceSelecao=3 },

                //Panama
                new EstatisticaS {Id=16, Nome="Ataque", Valor="68", IndiceSelecao=4 },
                new EstatisticaS {Id=17, Nome="Meio-Campo", Valor="68", IndiceSelecao=4 },
                new EstatisticaS {Id=18, Nome="Defesa", Valor="68", IndiceSelecao=4 },
                new EstatisticaS {Id=19, Nome="Capitão", Valor="Torres", IndiceSelecao=4 },
                new EstatisticaS {Id=20, Nome="Avaliação Geral", Valor="3", IndiceSelecao=4 },
            };
            estatisticaS.ForEach(aa => context.EstatisticaS.AddOrUpdate(a => a.Nome, aa));
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
            equipamentos.ForEach(aa => context.Equipamentos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //adicionar Jogadores
            var jogadores = new List<Jogadores> {
                
            //Jogadores de Inglaterra
            new Jogadores {Id=1, Nome="Harry Kane", Posicao="PLE", Imagem="HarryKane.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[0], estatisticaJ[1], estatisticaJ[2], estatisticaJ[3], estatisticaJ[4], estatisticaJ[5], estatisticaJ[6], estatisticaJ[7]}},
            new Jogadores {Id=2, Nome="Sterling", Posicao="PLD", Imagem="Sterling.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[8], estatisticaJ[9], estatisticaJ[10], estatisticaJ[11], estatisticaJ[12], estatisticaJ[13], estatisticaJ[14]}},
            new Jogadores {Id=3, Nome="Dele Ali", Posicao="MCE", Imagem="DeleAli.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[15], estatisticaJ[16], estatisticaJ[17], estatisticaJ[18], estatisticaJ[19], estatisticaJ[20]}},
            new Jogadores {Id=4, Nome="Henderson", Posicao="MC", Imagem="Henderson.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[21], estatisticaJ[22], estatisticaJ[23], estatisticaJ[24], estatisticaJ[25], estatisticaJ[26], estatisticaJ[27]}},
            new Jogadores {Id=5, Nome="Lingard", Posicao="MCD", Imagem="Lingard.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[28], estatisticaJ[29], estatisticaJ[30], estatisticaJ[31], estatisticaJ[32], estatisticaJ[33], estatisticaJ[34]}},
            new Jogadores {Id=6, Nome="Young", Posicao="LEO", Imagem="Young.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[35], estatisticaJ[36], estatisticaJ[37], estatisticaJ[38], estatisticaJ[39], estatisticaJ[40], estatisticaJ[41]}},
            new Jogadores {Id=7, Nome="Maguire", Posicao="DCE", Imagem="Maguire.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[42], estatisticaJ[43], estatisticaJ[44], estatisticaJ[45], estatisticaJ[46], estatisticaJ[47], estatisticaJ[48]}},
            new Jogadores {Id=8, Nome="Stones", Posicao="DC", Imagem="Henderson.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[49], estatisticaJ[50], estatisticaJ[51], estatisticaJ[52], estatisticaJ[53], estatisticaJ[54], estatisticaJ[55]}},
            new Jogadores {Id=9, Nome="Walker", Posicao="DCD", Imagem="Walker.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[56], estatisticaJ[57], estatisticaJ[58], estatisticaJ[59], estatisticaJ[60], estatisticaJ[61], estatisticaJ[62]}},
            new Jogadores {Id=10, Nome="Trippier", Posicao="LDO", Imagem="Trippier.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[63], estatisticaJ[64], estatisticaJ[65], estatisticaJ[66], estatisticaJ[67], estatisticaJ[68], estatisticaJ[69]}},
            new Jogadores {Id=11, Nome="Pickford", Posicao="GR", Imagem="Pickford.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[70], estatisticaJ[71], estatisticaJ[72], estatisticaJ[73], estatisticaJ[74]}},

            //Jogadores da Belgica
            new Jogadores {Id=12, Nome="Lukaku", Posicao="PL", Imagem="Lukaku.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[75], estatisticaJ[76], estatisticaJ[77], estatisticaJ[78], estatisticaJ[79], estatisticaJ[80], estatisticaJ[81]}},
            new Jogadores {Id=13, Nome="Hazard", Posicao="AE", Imagem="Hazard.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[82],estatisticaJ[83],estatisticaJ[84],estatisticaJ[85],estatisticaJ[86],estatisticaJ[87],estatisticaJ[88] }},
            new Jogadores {Id=14, Nome="Mertens", Posicao="AD", Imagem="Mertens.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[89], estatisticaJ[90],estatisticaJ[91],estatisticaJ[92],estatisticaJ[93],estatisticaJ[94],estatisticaJ[95], }},
            new Jogadores {Id=15, Nome="Carrasco", Posicao="ME", Imagem="Carrasco.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[96], estatisticaJ[97], estatisticaJ[98], estatisticaJ[99], estatisticaJ[100], estatisticaJ[101], estatisticaJ[102]}},
            new Jogadores {Id=16, Nome="Witsel", Posicao="MCE", Imagem="Witsel.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[103], estatisticaJ[104], estatisticaJ[105], estatisticaJ[106], estatisticaJ[107], estatisticaJ[108], estatisticaJ[109]}},
            new Jogadores {Id=17, Nome="De Bruyne", Posicao="MCD", Imagem="DeBruyne.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[110], estatisticaJ[111], estatisticaJ[112], estatisticaJ[113], estatisticaJ[114], estatisticaJ[115], estatisticaJ[116], estatisticaJ[117]}},
            new Jogadores {Id=18, Nome="Meunier", Posicao="MD", Imagem="Meunier.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[118], estatisticaJ[119], estatisticaJ[120], estatisticaJ[121], estatisticaJ[122], estatisticaJ[123], estatisticaJ[124]}},
            new Jogadores {Id=19, Nome="Vertonghen", Posicao="DCE", Imagem="Vertonghen.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[125], estatisticaJ[126], estatisticaJ[127], estatisticaJ[128], estatisticaJ[129], estatisticaJ[130], estatisticaJ[131]}},
            new Jogadores {Id=20, Nome="Kompany", Posicao="DC", Imagem="Kompany.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[132], estatisticaJ[133], estatisticaJ[134], estatisticaJ[135], estatisticaJ[136], estatisticaJ[137], estatisticaJ[138]}},
            new Jogadores {Id=21, Nome="Alderweireld", Posicao="DCD", Imagem="Alderweireld.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[139], estatisticaJ[140], estatisticaJ[141], estatisticaJ[142], estatisticaJ[143], estatisticaJ[144], estatisticaJ[145]}},
            new Jogadores {Id=22, Nome="Courtois", Posicao="GR", Imagem="Courtois.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[146], estatisticaJ[147], estatisticaJ[148], estatisticaJ[149], estatisticaJ[150]}},

            //Jogadores da Tunisia
            new Jogadores {Id=23, Nome="Khazri", Posicao="PL", Imagem="Khazri.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[151], estatisticaJ[152], estatisticaJ[153], estatisticaJ[154], estatisticaJ[155], estatisticaJ[156], estatisticaJ[157]}},
            new Jogadores {Id=24, Nome="Badri", Posicao="ME", Imagem="Badri.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[158],estatisticaJ[159],estatisticaJ[160],estatisticaJ[161],estatisticaJ[162],estatisticaJ[163],estatisticaJ[164] }},
            new Jogadores {Id=25, Nome="Khaoui", Posicao="MCE", Imagem="Khaoui.png", EstatisticaJ=new List<EstatisticaJ>{estatisticaJ[165], estatisticaJ[166],estatisticaJ[167],estatisticaJ[168],estatisticaJ[169],estatisticaJ[170],estatisticaJ[171] }},
            new Jogadores {Id=26, Nome="Sassi", Posicao="MCD", Imagem="Sassi.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[172], estatisticaJ[173], estatisticaJ[174], estatisticaJ[175], estatisticaJ[176], estatisticaJ[177], estatisticaJ[178]}},
            new Jogadores {Id=27, Nome="Ben Youssef", Posicao="MD", Imagem="Ben Youssef_MD.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[179], estatisticaJ[180], estatisticaJ[181], estatisticaJ[182], estatisticaJ[183], estatisticaJ[184], estatisticaJ[185]}},
            new Jogadores {Id=28, Nome="Skhiri", Posicao="MDC", Imagem="Skhiri.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[186], estatisticaJ[187], estatisticaJ[188], estatisticaJ[189], estatisticaJ[190], estatisticaJ[191], estatisticaJ[192]}},
            new Jogadores {Id=29, Nome="Maâloul", Posicao="DE", Imagem="Maaloul.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[193], estatisticaJ[194], estatisticaJ[195], estatisticaJ[196], estatisticaJ[197], estatisticaJ[198], estatisticaJ[199]}},
            new Jogadores {Id=30, Nome="Meriah", Posicao="DC", Imagem="Meriah.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[200], estatisticaJ[201], estatisticaJ[202], estatisticaJ[203], estatisticaJ[204], estatisticaJ[205], estatisticaJ[206]}},
            new Jogadores {Id=31, Nome="Ben Youssef", Posicao="DC", Imagem="Ben Youssef_DC.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[207], estatisticaJ[208], estatisticaJ[209], estatisticaJ[210], estatisticaJ[211], estatisticaJ[212], estatisticaJ[213]}},
            new Jogadores {Id=32, Nome="Bronn", Posicao="DCD", Imagem="Bronn.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[214], estatisticaJ[215], estatisticaJ[216], estatisticaJ[217], estatisticaJ[218], estatisticaJ[219], estatisticaJ[220]}},
            new Jogadores {Id=33, Nome="Mustapha", Posicao="GR", Imagem="Mustapha.png", EstatisticaJ=new List<EstatisticaJ>{ estatisticaJ[221], estatisticaJ[222], estatisticaJ[223], estatisticaJ[224], estatisticaJ[225]}},


            };
            jogadores.ForEach(aa => context.Jogadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //adicionar Selecoes
            var selecoes = new List<Selecoes> {

            new Selecoes {Id=1, Nome="Inglaterra", Emblema="Inglaterra.png", Jogadores=new List<Jogadores>{ jogadores[0], jogadores[1], jogadores[2], jogadores[3], jogadores[4], jogadores[5], jogadores[6], jogadores[7], jogadores[8], jogadores[9], jogadores[10] } , Equipamentos=new List<Equipamentos>{ equipamentos[0], equipamentos[1], equipamentos[2]}, EstatisticaS=new List<EstatisticaS>{ estatisticaS[0], estatisticaS[1], estatisticaS[2], estatisticaS[3], estatisticaS[4]}},
            new Selecoes {Id=2, Nome="Belgica", Emblema="Belgica.png", Jogadores=new List<Jogadores>{ jogadores[11], jogadores[12], jogadores[13], jogadores[14], jogadores[15], jogadores[16], jogadores[17], jogadores[18], jogadores[19], jogadores[20], jogadores[21] } , Equipamentos=new List<Equipamentos>{ equipamentos[3], equipamentos[4], equipamentos[5]}, EstatisticaS=new List<EstatisticaS>{ estatisticaS[5], estatisticaS[6], estatisticaS[7], estatisticaS[8], estatisticaS[9]}},
            new Selecoes {Id=3, Nome="Tunisia", Emblema="Tunisia.png", Jogadores=new List<Jogadores>{ jogadores[22], jogadores[23], jogadores[24], jogadores[25], jogadores[26], jogadores[27], jogadores[28], jogadores[29], jogadores[30], jogadores[31], jogadores[32] } , Equipamentos=new List<Equipamentos>{ equipamentos[6], equipamentos[7], equipamentos[8]}, EstatisticaS=new List<EstatisticaS>{ estatisticaS[10], estatisticaS[11], estatisticaS[12], estatisticaS[13], estatisticaS[14]}},

            };
            selecoes.ForEach(aa => context.Selecoes.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
























            // adiciona GRUPOS
            var grupos = new List<Grupos> {
            new Grupos {Id=1, Nome="Grupo G", Selecoes= new List<Selecoes>{selecoes[0], selecoes[1], selecoes[2] } },
         };
            grupos.ForEach(aa => context.Grupos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
        }
    }
}
