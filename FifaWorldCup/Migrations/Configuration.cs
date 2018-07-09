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
            // adiciona GRUPOS
            var grupos = new List<Grupos> {
            new Grupos {Id=1, Nome="Grupo G" },
             };
            grupos.ForEach(aa => context.Grupos.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();

            //adicionar Selecoes
            var selecoes = new List<Selecoes> {

            new Selecoes {Id=1, Nome="Inglaterra", Emblema="Inglaterra.png", IndideGrupo=1},
            new Selecoes {Id=2, Nome="Belgica", Emblema="Belgica.png", IndideGrupo=1},
            new Selecoes {Id=3, Nome="Tunisia", Emblema="Tunisia.png",IndideGrupo=1},
            new Selecoes {Id=4, Nome="Panama", Emblema="Panama.png", IndideGrupo=1},

            };
            selecoes.ForEach(aa => context.Selecoes.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();



            //adicionar Jogadores
            var jogadores = new List<Jogadores> {
                
            //Jogadores de Inglaterra
            new Jogadores {Id=1, Nome="Harry Kane", Posicao="PLE", Imagem="HarryKane.png",IndiceSelecao=1},
            new Jogadores {Id=2, Nome="Sterling", Posicao="PLD", Imagem="Sterling.png",IndiceSelecao=1},
            new Jogadores {Id=3, Nome="Dele Ali", Posicao="MCE", Imagem="DeleAli.png",IndiceSelecao=1},
            new Jogadores {Id=4, Nome="Henderson", Posicao="MC", Imagem="Henderson.png", IndiceSelecao=1},
            new Jogadores {Id=5, Nome="Lingard", Posicao="MCD", Imagem="Lingard.png",IndiceSelecao=1},
            new Jogadores {Id=6, Nome="Young", Posicao="LEO", Imagem="Young.png",IndiceSelecao=1},
            new Jogadores {Id=7, Nome="Maguire", Posicao="DCE", Imagem="Maguire.png",IndiceSelecao=1},
            new Jogadores {Id=8, Nome="Stones", Posicao="DC", Imagem="Henderson.png",IndiceSelecao=1},
            new Jogadores {Id=9, Nome="Walker", Posicao="DCD", Imagem="Walker.png",IndiceSelecao=1},
            new Jogadores {Id=10, Nome="Trippier", Posicao="LDO", Imagem="Trippier.png",IndiceSelecao=1},
            new Jogadores {Id=11, Nome="Pickford", Posicao="GR", Imagem="Pickford.png",IndiceSelecao=1},

            //Jogadores da Belgica
            new Jogadores {Id=12, Nome="Lukaku", Posicao="PL", Imagem="Lukaku.png",IndiceSelecao=2},
            new Jogadores {Id=13, Nome="Hazard", Posicao="AE", Imagem="Hazard.png",IndiceSelecao=2},
            new Jogadores {Id=14, Nome="Mertens", Posicao="AD", Imagem="Mertens.png", IndiceSelecao=2},
            new Jogadores {Id=15, Nome="Carrasco", Posicao="ME", Imagem="Carrasco.png",IndiceSelecao=2},
            new Jogadores {Id=16, Nome="Witsel", Posicao="MCE", Imagem="Witsel.png", IndiceSelecao=2},
            new Jogadores {Id=17, Nome="De Bruyne", Posicao="MCD", Imagem="DeBruyne.png",IndiceSelecao=2},
            new Jogadores {Id=18, Nome="Meunier", Posicao="MD", Imagem="Meunier.png", IndiceSelecao=2},
            new Jogadores {Id=19, Nome="Vertonghen", Posicao="DCE", Imagem="Vertonghen.png",IndiceSelecao=2},
            new Jogadores {Id=20, Nome="Kompany", Posicao="DC", Imagem="Kompany.png",IndiceSelecao=2},
            new Jogadores {Id=21, Nome="Alderweireld", Posicao="DCD", Imagem="Alderweireld.png", IndiceSelecao=2},
            new Jogadores {Id=22, Nome="Courtois", Posicao="GR", Imagem="Courtois.png",IndiceSelecao=2},

            //Jogadores da Tunisia
            new Jogadores {Id=23, Nome="Khazri", Posicao="PL", Imagem="Khazri.png",IndiceSelecao=3},
            new Jogadores {Id=24, Nome="Badri", Posicao="ME", Imagem="Badri.png",IndiceSelecao=3},
            new Jogadores {Id=25, Nome="Khaoui", Posicao="MCE", Imagem="Khaoui.png",IndiceSelecao=3},
            new Jogadores {Id=26, Nome="Sassi", Posicao="MCD", Imagem="Sassi.png",IndiceSelecao=3},
            new Jogadores {Id=27, Nome="Ben Youssef", Posicao="MD", Imagem="Ben Youssef_MD.png",IndiceSelecao=3},
            new Jogadores {Id=28, Nome="Skhiri", Posicao="MDC", Imagem="Skhiri.png",IndiceSelecao=3},
            new Jogadores {Id=29, Nome="Maâloul", Posicao="DE", Imagem="Maaloul.png",IndiceSelecao=3},
            new Jogadores {Id=30, Nome="Meriah", Posicao="DC", Imagem="Meriah.png",IndiceSelecao=3},
            new Jogadores {Id=31, Nome="Ben Youssef", Posicao="DC", Imagem="Ben Youssef_DC.png", IndiceSelecao=3},
            new Jogadores {Id=32, Nome="Bronn", Posicao="DCD", Imagem="Bronn.png", IndiceSelecao=3},
            new Jogadores {Id=33, Nome="Mustapha", Posicao="GR", Imagem="Mustapha.png",IndiceSelecao=3},

            //Jogadores do Panama
            new Jogadores {Id=34, Nome="Perez", Posicao="PL", Imagem="Perez.png",IndiceSelecao=4},
            new Jogadores {Id=35, Nome="Rodriguez", Posicao="ME", Imagem="Rodriguez.png",IndiceSelecao=4},
            new Jogadores {Id=36, Nome="Godoy", Posicao="MCE", Imagem="Godoy.png",IndiceSelecao=4},
            new Jogadores {Id=37, Nome="Cooper", Posicao="MCD", Imagem="Cooper.png",IndiceSelecao=4},
            new Jogadores {Id=38, Nome="Barcenas", Posicao="MD", Imagem="Barcenas.png",IndiceSelecao=4},
            new Jogadores {Id=39, Nome="Gomez", Posicao="MDC", Imagem="Gomez.png",IndiceSelecao=4},
            new Jogadores {Id=40, Nome="Davis", Posicao="DE", Imagem="Davis.png",IndiceSelecao=4},
            new Jogadores {Id=41, Nome="Escobar", Posicao="DC", Imagem="Escobar.png",IndiceSelecao=4},
            new Jogadores {Id=42, Nome="Torres", Posicao="DC", Imagem="Torres.png",IndiceSelecao=4},
            new Jogadores {Id=43, Nome="Murillo", Posicao="DCD", Imagem="Murillo.png",IndiceSelecao=4},
            new Jogadores {Id=44, Nome="Penedo", Posicao="GR", Imagem="Penedo.png",IndiceSelecao=4},

            };
            jogadores.ForEach(aa => context.Jogadores.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();






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

            
            //---------------------------  PANAMA --------------------------------

            //Perez
            new EstatisticaJ {Id=227, Nome="Aceleração", Valor=65, IndiceJogador=34 },
            new EstatisticaJ {Id=228, Nome="Resistência", Valor=64, IndiceJogador=34 },
            new EstatisticaJ {Id=229, Nome="Força", Valor=80, IndiceJogador=34 },
            new EstatisticaJ {Id=230, Nome="Equilibrio", Valor=65, IndiceJogador=34},
            new EstatisticaJ {Id=231, Nome="Sprint", Valor=63, IndiceJogador=34 },
            new EstatisticaJ {Id=232, Nome="Agilidade", Valor=64, IndiceJogador=34 },
            new EstatisticaJ {Id=233, Nome="Salto", Valor=75, IndiceJogador=34},
            
            //Rodriguez
            new EstatisticaJ {Id=234, Nome="Aceleração", Valor=72, IndiceJogador=35 },
            new EstatisticaJ {Id=235, Nome="Resistência", Valor=47, IndiceJogador=35 },
            new EstatisticaJ {Id=236, Nome="Força", Valor=58, IndiceJogador=35 },
            new EstatisticaJ {Id=237, Nome="Equilibrio", Valor=73, IndiceJogador=35},
            new EstatisticaJ {Id=238, Nome="Sprint", Valor=68, IndiceJogador=35 },
            new EstatisticaJ {Id=239, Nome="Agilidade", Valor=74, IndiceJogador=35 },
            new EstatisticaJ {Id=240, Nome="Salto", Valor=68, IndiceJogador=35},
                    
            //Godoy
            new EstatisticaJ {Id=241, Nome="Aceleração", Valor=50, IndiceJogador=36 },
            new EstatisticaJ {Id=242, Nome="Resistência", Valor=78, IndiceJogador=36 },
            new EstatisticaJ {Id=243, Nome="Força", Valor=73, IndiceJogador=36 },
            new EstatisticaJ {Id=244, Nome="Equilibrio", Valor=66, IndiceJogador=36},
            new EstatisticaJ {Id=245, Nome="Sprint", Valor=53, IndiceJogador=36 },
            new EstatisticaJ {Id=246, Nome="Agilidade", Valor=67, IndiceJogador=36 },
            new EstatisticaJ {Id=247, Nome="Salto", Valor=64, IndiceJogador=36},
                    
            //Cooper
            new EstatisticaJ {Id=248, Nome="Aceleração", Valor=79, IndiceJogador=37 },
            new EstatisticaJ {Id=249, Nome="Resistência", Valor=77, IndiceJogador=37 },
            new EstatisticaJ {Id=250, Nome="Força", Valor=56, IndiceJogador=37 },
            new EstatisticaJ {Id=251, Nome="Equilibrio", Valor=76, IndiceJogador=37},
            new EstatisticaJ {Id=252, Nome="Sprint", Valor=78, IndiceJogador=37 },
            new EstatisticaJ {Id=253, Nome="Agilidade", Valor=79, IndiceJogador=37 },
            new EstatisticaJ {Id=254, Nome="Salto", Valor=65, IndiceJogador=37},
            
            //Barcenas
            new EstatisticaJ {Id=255, Nome="Aceleração", Valor=83, IndiceJogador=38 },
            new EstatisticaJ {Id=256, Nome="Resistência", Valor=62, IndiceJogador=38 },
            new EstatisticaJ {Id=257, Nome="Força", Valor=52, IndiceJogador=38 },
            new EstatisticaJ {Id=258, Nome="Equilibrio", Valor=74, IndiceJogador=38},
            new EstatisticaJ {Id=259, Nome="Sprint", Valor=82, IndiceJogador=38 },
            new EstatisticaJ {Id=260, Nome="Agilidade", Valor=82, IndiceJogador=38 },
            new EstatisticaJ {Id=261, Nome="Salto", Valor=58, IndiceJogador=38},
            
            //Gomez
            new EstatisticaJ {Id=262, Nome="Aceleração", Valor=64, IndiceJogador=39 },
            new EstatisticaJ {Id=263, Nome="Resistência", Valor=74, IndiceJogador=39 },
            new EstatisticaJ {Id=264, Nome="Força", Valor=77, IndiceJogador=39 },
            new EstatisticaJ {Id=265, Nome="Equilibrio", Valor=62, IndiceJogador=39},
            new EstatisticaJ {Id=266, Nome="Sprint", Valor=66, IndiceJogador=39 },
            new EstatisticaJ {Id=267, Nome="Agilidade", Valor=81, IndiceJogador=39 },
            new EstatisticaJ {Id=268, Nome="Salto", Valor=66, IndiceJogador=39},

            //Davis
            new EstatisticaJ {Id=269, Nome="Aceleração", Valor=74, IndiceJogador=40 },
            new EstatisticaJ {Id=270, Nome="Resistência", Valor=66, IndiceJogador=40 },
            new EstatisticaJ {Id=271, Nome="Força", Valor=63, IndiceJogador=40 },
            new EstatisticaJ {Id=272, Nome="Equilibrio", Valor=62, IndiceJogador=40},
            new EstatisticaJ {Id=273, Nome="Sprint", Valor=73, IndiceJogador=40 },
            new EstatisticaJ {Id=274, Nome="Agilidade", Valor=60, IndiceJogador=40 },
            new EstatisticaJ {Id=275, Nome="Salto", Valor=64, IndiceJogador=40},

            //Escobar
            new EstatisticaJ {Id=276, Nome="Aceleração", Valor=75, IndiceJogador=41 },
            new EstatisticaJ {Id=277, Nome="Resistência", Valor=79, IndiceJogador=41 },
            new EstatisticaJ {Id=278, Nome="Força", Valor=75, IndiceJogador=41 },
            new EstatisticaJ {Id=279, Nome="Equilibrio", Valor=68, IndiceJogador=41},
            new EstatisticaJ {Id=280, Nome="Sprint", Valor=78, IndiceJogador=41 },
            new EstatisticaJ {Id=281, Nome="Agilidade", Valor=57, IndiceJogador=41 },
            new EstatisticaJ {Id=282, Nome="Salto", Valor=75, IndiceJogador=41},

            //Torres
            new EstatisticaJ {Id=283, Nome="Aceleração", Valor=44, IndiceJogador=42 },
            new EstatisticaJ {Id=284, Nome="Resistência", Valor=55, IndiceJogador=42 },
            new EstatisticaJ {Id=285, Nome="Força", Valor=92, IndiceJogador=42 },
            new EstatisticaJ {Id=286, Nome="Equilibrio", Valor=32, IndiceJogador=42},
            new EstatisticaJ {Id=287, Nome="Sprint", Valor=55, IndiceJogador=42 },
            new EstatisticaJ {Id=288, Nome="Agilidade", Valor=34, IndiceJogador=42 },
            new EstatisticaJ {Id=289, Nome="Salto", Valor=55, IndiceJogador=42},

            //Murillo
            new EstatisticaJ {Id=290, Nome="Aceleração", Valor=79, IndiceJogador=43 },
            new EstatisticaJ {Id=291, Nome="Resistência", Valor=78, IndiceJogador=43 },
            new EstatisticaJ {Id=292, Nome="Força", Valor=71, IndiceJogador=43 },
            new EstatisticaJ {Id=293, Nome="Equilibrio", Valor=69, IndiceJogador=43},
            new EstatisticaJ {Id=294, Nome="Sprint", Valor=80, IndiceJogador=43 },
            new EstatisticaJ {Id=295, Nome="Agilidade", Valor=72, IndiceJogador=43 },
            new EstatisticaJ {Id=296, Nome="Salto", Valor=87, IndiceJogador=43},

            //Penedo
            new EstatisticaJ {Id=297, Nome="Posic.", Valor=65, IndiceJogador=44 },
            new EstatisticaJ {Id=298, Nome="Mergulho GR", Valor=68, IndiceJogador=44 },
            new EstatisticaJ {Id=299, Nome="Jogo Mãos GR", Valor=62, IndiceJogador=44 },
            new EstatisticaJ {Id=300, Nome="Jogo Pés GR", Valor=55, IndiceJogador=44 },
            new EstatisticaJ {Id=301, Nome="Reflexos GR", Valor=75, IndiceJogador=44 },


            };
            estatisticaJ.ForEach(aa => context.EstatisticaJ.AddOrUpdate(a => a.Id, aa));
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
            estatisticaS.ForEach(aa => context.EstatisticaS.AddOrUpdate(a => a.Id, aa));
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
            equipamentos.ForEach(aa => context.Equipamentos.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();


        }
    }
}
