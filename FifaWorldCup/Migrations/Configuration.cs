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
            new Grupos {Id=1, Nome="Grupo B" },
            new Grupos {Id=2, Nome="Grupo G" }
             };
            grupos.ForEach(aa => context.Grupos.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();

            //adicionar Selecoes
            var selecoes = new List<Selecoes> {

            //Grupo B
            
            new Selecoes {Id=1, Nome="Portugal", Emblema="Portugal.png", IndiceGrupo=1},
            new Selecoes {Id=2, Nome="Espanha", Emblema="Espanha.png", IndiceGrupo=1},
            new Selecoes {Id=3, Nome="Irão", Emblema="Irao.png",IndiceGrupo=1},
            new Selecoes {Id=4, Nome="Marrocos", Emblema="Marrocos.png", IndiceGrupo=1},


            //Grupo G
            new Selecoes {Id=5, Nome="Inglaterra", Emblema="Inglaterra.png", IndiceGrupo=2},
            new Selecoes {Id=6, Nome="Belgica", Emblema="Belgica.png", IndiceGrupo=2},
            new Selecoes {Id=7, Nome="Tunisia", Emblema="Tunisia.png",IndiceGrupo=2},
            new Selecoes {Id=8, Nome="Panama", Emblema="Panama.png", IndiceGrupo=2},

            };
            selecoes.ForEach(aa => context.Selecoes.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();



            //adicionar Jogadores
            var jogadores = new List<Jogadores> {
                
            //Jogadores de Inglaterra
            new Jogadores {Id=1, Nome="Harry Kane", Posicao="PLE", Imagem="HarryKane.png",IndiceSelecao=5},
            new Jogadores {Id=2, Nome="Sterling", Posicao="PLD", Imagem="Sterling.png",IndiceSelecao=5},
            new Jogadores {Id=3, Nome="Dele Ali", Posicao="MCE", Imagem="DeleAli.png",IndiceSelecao=5},
            new Jogadores {Id=4, Nome="Henderson", Posicao="MC", Imagem="Henderson.png", IndiceSelecao=5},
            new Jogadores {Id=5, Nome="Lingard", Posicao="MCD", Imagem="Lingard.png",IndiceSelecao=5},
            new Jogadores {Id=6, Nome="Young", Posicao="LEO", Imagem="Young.png",IndiceSelecao=5},
            new Jogadores {Id=7, Nome="Maguire", Posicao="DCE", Imagem="Maguire.png",IndiceSelecao=5},
            new Jogadores {Id=8, Nome="Stones", Posicao="DC", Imagem="Henderson.png",IndiceSelecao=5},
            new Jogadores {Id=9, Nome="Walker", Posicao="DCD", Imagem="Walker.png",IndiceSelecao=5},
            new Jogadores {Id=10, Nome="Trippier", Posicao="LDO", Imagem="Trippier.png",IndiceSelecao=5},
            new Jogadores {Id=11, Nome="Pickford", Posicao="GR", Imagem="Pickford.png",IndiceSelecao=5},

            //Jogadores da Belgica
            new Jogadores {Id=12, Nome="Lukaku", Posicao="PL", Imagem="Lukaku.png",IndiceSelecao=6},
            new Jogadores {Id=13, Nome="Hazard", Posicao="AE", Imagem="Hazard.png",IndiceSelecao=6},
            new Jogadores {Id=14, Nome="Mertens", Posicao="AD", Imagem="Mertens.png", IndiceSelecao=6},
            new Jogadores {Id=15, Nome="Carrasco", Posicao="ME", Imagem="Carrasco.png",IndiceSelecao=6},
            new Jogadores {Id=16, Nome="Witsel", Posicao="MCE", Imagem="Witsel.png", IndiceSelecao=6},
            new Jogadores {Id=17, Nome="De Bruyne", Posicao="MCD", Imagem="DeBruyne.png",IndiceSelecao=6},
            new Jogadores {Id=18, Nome="Meunier", Posicao="MD", Imagem="Meunier.png", IndiceSelecao=6},
            new Jogadores {Id=19, Nome="Vertonghen", Posicao="DCE", Imagem="Vertonghen.png",IndiceSelecao=6},
            new Jogadores {Id=20, Nome="Kompany", Posicao="DC", Imagem="Kompany.png",IndiceSelecao=6},
            new Jogadores {Id=21, Nome="Alderweireld", Posicao="DCD", Imagem="Alderweireld.png", IndiceSelecao=6},
            new Jogadores {Id=22, Nome="Courtois", Posicao="GR", Imagem="Courtois.png",IndiceSelecao=6},

            //Jogadores da Tunisia
            new Jogadores {Id=23, Nome="Khazri", Posicao="PL", Imagem="Khazri.png",IndiceSelecao=7},
            new Jogadores {Id=24, Nome="Badri", Posicao="ME", Imagem="Badri.png",IndiceSelecao=7},
            new Jogadores {Id=25, Nome="Khaoui", Posicao="MCE", Imagem="Khaoui.png",IndiceSelecao=7},
            new Jogadores {Id=26, Nome="Sassi", Posicao="MCD", Imagem="Sassi.png",IndiceSelecao=7},
            new Jogadores {Id=27, Nome="Ben Youssef", Posicao="MD", Imagem="Ben_Youssef_MD.png",IndiceSelecao=7},
            new Jogadores {Id=28, Nome="Skhiri", Posicao="MDC", Imagem="Skhiri.png",IndiceSelecao=7},
            new Jogadores {Id=29, Nome="Maâloul", Posicao="DE", Imagem="Maaloul.png",IndiceSelecao=7},
            new Jogadores {Id=30, Nome="Meriah", Posicao="DC", Imagem="Meriah.png",IndiceSelecao=7},
            new Jogadores {Id=31, Nome="Ben Youssef", Posicao="DC", Imagem="Ben_Youssef_DC.png", IndiceSelecao=7},
            new Jogadores {Id=32, Nome="Bronn", Posicao="DD", Imagem="Bronn.png", IndiceSelecao=7},
            new Jogadores {Id=33, Nome="Mustapha", Posicao="GR", Imagem="Mustapha.png",IndiceSelecao=7},

            //Jogadores do Panama
            new Jogadores {Id=34, Nome="Perez", Posicao="PL", Imagem="Perez.png",IndiceSelecao=8},
            new Jogadores {Id=35, Nome="Rodriguez", Posicao="ME", Imagem="Rodriguez.png",IndiceSelecao=8},
            new Jogadores {Id=36, Nome="Godoy", Posicao="MCE", Imagem="Godoy.png",IndiceSelecao=8},
            new Jogadores {Id=37, Nome="Cooper", Posicao="MCD", Imagem="Cooper.png",IndiceSelecao=8},
            new Jogadores {Id=38, Nome="Barcenas", Posicao="MD", Imagem="Barcenas.png",IndiceSelecao=8},
            new Jogadores {Id=39, Nome="Gomez", Posicao="MDC", Imagem="Gomez.png",IndiceSelecao=8},
            new Jogadores {Id=40, Nome="Davis", Posicao="DE", Imagem="Davis.png",IndiceSelecao=8},
            new Jogadores {Id=41, Nome="Escobar", Posicao="DC", Imagem="Escobar.png",IndiceSelecao=8},
            new Jogadores {Id=42, Nome="Torres", Posicao="DC", Imagem="Torres.png",IndiceSelecao=8},
            new Jogadores {Id=43, Nome="Murillo", Posicao="DD", Imagem="Murillo.png",IndiceSelecao=8},
            new Jogadores {Id=44, Nome="Penedo", Posicao="GR", Imagem="Penedo.png",IndiceSelecao=8},

            //Jogadores de Portugal
            new Jogadores {Id=45, Nome="C.Ronaldo", Posicao="PLE", Imagem="C_Ronaldo.png",IndiceSelecao=1},
            new Jogadores {Id=46, Nome="A.Siva", Posicao="PLD", Imagem="A_Silva.png",IndiceSelecao=1},
            new Jogadores {Id=47, Nome="J.Mario", Posicao="ME", Imagem="J_Mario.png",IndiceSelecao=1},
            new Jogadores {Id=48, Nome="Adrien", Posicao="MC", Imagem="Adrien.png",IndiceSelecao=1},
            new Jogadores {Id=49, Nome="Quaresma", Posicao="MD", Imagem="Quaresma.png",IndiceSelecao=1},
            new Jogadores {Id=50, Nome="W.Carvalho", Posicao="MDC", Imagem="W_Carvalho.png",IndiceSelecao=1},
            new Jogadores {Id=51, Nome="Guerreiro", Posicao="DE", Imagem="Guerreiro.png",IndiceSelecao=1},
            new Jogadores {Id=52, Nome="Fonte", Posicao="DC", Imagem="Fonte.png",IndiceSelecao=1},
            new Jogadores {Id=53, Nome="Pepe", Posicao="DC", Imagem="Pepe.png",IndiceSelecao=1},
            new Jogadores {Id=54, Nome="Cedric", Posicao="DD", Imagem="Cedric.png",IndiceSelecao=1},
            new Jogadores {Id=55, Nome="Patricio", Posicao="GR", Imagem="Patricio.png",IndiceSelecao=1},
            
            //Jogadores de Espanha
            new Jogadores {Id=56, Nome="Costa", Posicao="PL", Imagem="Costa.png",IndiceSelecao=2},
            new Jogadores {Id=57, Nome="Isco", Posicao="EE", Imagem="Isco.png",IndiceSelecao=2},
            new Jogadores {Id=58, Nome="D.Silva", Posicao="ED", Imagem="D_Silva.png",IndiceSelecao=2},
            new Jogadores {Id=59, Nome="Iniesta", Posicao="MC", Imagem="Iniesta.png",IndiceSelecao=2},
            new Jogadores {Id=60, Nome="Thiago", Posicao="MC", Imagem="Thiago.png",IndiceSelecao=2},
            new Jogadores {Id=61, Nome="Busquets", Posicao="MDC", Imagem="Busquets.png",IndiceSelecao=2},
            new Jogadores {Id=62, Nome="J.Alba", Posicao="DE", Imagem="J_Alba.png",IndiceSelecao=2},
            new Jogadores {Id=63, Nome="S.Ramos", Posicao="DC", Imagem="S_Ramos.png",IndiceSelecao=2},
            new Jogadores {Id=64, Nome="Pique", Posicao="DC", Imagem="Pique.png",IndiceSelecao=2},
            new Jogadores {Id=65, Nome="Carvajal", Posicao="DD", Imagem="Carvajal.png",IndiceSelecao=2},
            new Jogadores {Id=66, Nome="De Gea", Posicao="GR", Imagem="De_Gea.png",IndiceSelecao=2},

            //Jogadores do Irao
            new Jogadores {Id=67, Nome="Azmoun", Posicao="PL", Imagem="Azmoun.png",IndiceSelecao=3},
            new Jogadores {Id=68, Nome="Taremi", Posicao="ME", Imagem="Taremi.png",IndiceSelecao=3},
            new Jogadores {Id=69, Nome="Amiri", Posicao="MC", Imagem="Amiri.png",IndiceSelecao=3},
            new Jogadores {Id=70, Nome="Ebrahimi", Posicao="MC", Imagem="Ebrahimi.png",IndiceSelecao=3},
            new Jogadores {Id=71, Nome="Jahanbakhsh", Posicao="MD", Imagem="Jahanbakhsh.png",IndiceSelecao=3},
            new Jogadores {Id=72, Nome="Ezatolahi", Posicao="MDC", Imagem="Ezatolahi.png",IndiceSelecao=3},
            new Jogadores {Id=73, Nome="Safi", Posicao="DE", Imagem="Safi.png",IndiceSelecao=3},
            new Jogadores {Id=74, Nome="Hosseini", Posicao="DC", Imagem="Hosseini.png",IndiceSelecao=3},
            new Jogadores {Id=75, Nome="Pouraliganji", Posicao="DC", Imagem="Pouraliganji.png",IndiceSelecao=3},
            new Jogadores {Id=76, Nome="Rezaeian", Posicao="DD", Imagem="Rezaeian.png",IndiceSelecao=3},
            new Jogadores {Id=77, Nome="Beiranvand", Posicao="GR", Imagem="Beiranvand.png",IndiceSelecao=3},

            //Jogadores de Marrocos
            new Jogadores {Id=78, Nome="Boutaib", Posicao="PL", Imagem="Boutaib.png",IndiceSelecao=4},
            new Jogadores {Id=79, Nome="Ziyach", Posicao="ME", Imagem="Ziyach.png",IndiceSelecao=4},
            new Jogadores {Id=80, Nome="Amrabat", Posicao="MD", Imagem="Amrabat.png",IndiceSelecao=4},
            new Jogadores {Id=81, Nome="Belhanda", Posicao="MC", Imagem="Belhanda.png",IndiceSelecao=4},
            new Jogadores {Id=82, Nome="Boussoufa", Posicao="MC", Imagem="Boussoufa.png",IndiceSelecao=4},
            new Jogadores {Id=83, Nome="Ahmadi", Posicao="MDC", Imagem="Ahmadi.png",IndiceSelecao=4},
            new Jogadores {Id=84, Nome="Hakimi", Posicao="DE", Imagem="Hakimi.png",IndiceSelecao=4},
            new Jogadores {Id=85, Nome="Saiss", Posicao="DC", Imagem="Saiss.png",IndiceSelecao=4},
            new Jogadores {Id=86, Nome="Benatia", Posicao="DC", Imagem="Benatia.png",IndiceSelecao=4},
            new Jogadores {Id=87, Nome="Dirar", Posicao="DD", Imagem="Dirar.png",IndiceSelecao=4},
            new Jogadores {Id=88, Nome="Kajoui", Posicao="GR", Imagem="Kajoui.png",IndiceSelecao=4},

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



             //---------------------------  PORTUGAL  --------------------------------
            
            //C RONALDO
            new EstatisticaJ {Id=302, Nome="Cabeceamento", Valor=95, IndiceJogador=45 },
            new EstatisticaJ {Id=303, Nome="Pot. Remate", Valor=93, IndiceJogador=45 },
            new EstatisticaJ {Id=304, Nome="Finalização", Valor=94, IndiceJogador=45 },
            new EstatisticaJ {Id=305, Nome="Rem. Longe", Valor=90, IndiceJogador=45 },
            new EstatisticaJ {Id=306, Nome="Efeito", Valor=84, IndiceJogador=45 },
            new EstatisticaJ {Id=307, Nome="Prec. Livres", Valor=79, IndiceJogador=45 },
            new EstatisticaJ {Id=308, Nome="Penaltis", Valor=86, IndiceJogador=45 },
            new EstatisticaJ {Id=309, Nome="Remates de 1ª", Valor=77, IndiceJogador=45 },

            //A SILVA
            new EstatisticaJ {Id=310, Nome="Aceleração", Valor=77, IndiceJogador=46 },
            new EstatisticaJ {Id=311, Nome="Resistência", Valor=86, IndiceJogador=46 },
            new EstatisticaJ {Id=312, Nome="Força", Valor=79, IndiceJogador=46 },
            new EstatisticaJ {Id=313, Nome="Equilibrio", Valor=72, IndiceJogador=46 },
            new EstatisticaJ {Id=314, Nome="Sprint", Valor=85, IndiceJogador=46 },
            new EstatisticaJ {Id=315, Nome="Agilidade", Valor=83, IndiceJogador=46 },
            new EstatisticaJ {Id=316, Nome="Salto", Valor=84, IndiceJogador=46 },
                             
            //JOAO MARIO
            new EstatisticaJ {Id=310, Nome="Agressividade", Valor=66, IndiceJogador=47 },
            new EstatisticaJ {Id=311, Nome="Reflexos", Valor=84, IndiceJogador=47 },
            new EstatisticaJ {Id=312, Nome="Pos. Ataque", Valor=82, IndiceJogador=47 },
            new EstatisticaJ {Id=313, Nome="Interceções", Valor=77, IndiceJogador=47 },
            new EstatisticaJ {Id=314, Nome="Visão", Valor=85, IndiceJogador=47 },
            new EstatisticaJ {Id=315, Nome="Compostura", Valor=85, IndiceJogador=47 },
                            
            //Adrien
            new EstatisticaJ {Id=316, Nome="Aceleração", Valor=64, IndiceJogador=48 },
            new EstatisticaJ {Id=317, Nome="Resistência", Valor=89, IndiceJogador=48 },
            new EstatisticaJ {Id=318, Nome="Força", Valor=62, IndiceJogador=48},
            new EstatisticaJ {Id=319, Nome="Equilibrio", Valor=67, IndiceJogador=48 },
            new EstatisticaJ {Id=320, Nome="Sprint", Valor=65, IndiceJogador=48 },
            new EstatisticaJ {Id=321, Nome="Agilidade", Valor=73, IndiceJogador=48 },
            new EstatisticaJ {Id=322, Nome="Salto", Valor=56, IndiceJogador=48 },
            
            //Quaresma
            new EstatisticaJ {Id=323, Nome="Aceleração", Valor=85, IndiceJogador=49 },
            new EstatisticaJ {Id=324, Nome="Resistência", Valor=69, IndiceJogador=49 },
            new EstatisticaJ {Id=325, Nome="Força", Valor=54, IndiceJogador=49 },
            new EstatisticaJ {Id=326, Nome="Equilibrio", Valor=84, IndiceJogador=49 },
            new EstatisticaJ {Id=327, Nome="Sprint", Valor=82, IndiceJogador=49 },
            new EstatisticaJ {Id=328, Nome="Agilidade", Valor=91, IndiceJogador=49 },
            new EstatisticaJ {Id=329, Nome="Salto", Valor=63, IndiceJogador=49 },

            //W CARVALHO
            new EstatisticaJ {Id=330, Nome="Aceleração", Valor=52, IndiceJogador=50 },
            new EstatisticaJ {Id=331, Nome="Resistência", Valor=84, IndiceJogador=50 },
            new EstatisticaJ {Id=332, Nome="Força", Valor=88, IndiceJogador=50 },
            new EstatisticaJ {Id=333, Nome="Equilibrio", Valor=50, IndiceJogador=50 },
            new EstatisticaJ {Id=334, Nome="Sprint", Valor=53, IndiceJogador=50 },
            new EstatisticaJ {Id=335, Nome="Agilidade", Valor=45, IndiceJogador=50 },
            new EstatisticaJ {Id=336, Nome="Salto", Valor=68, IndiceJogador=50 },
            
             //GUERREIRO
            new EstatisticaJ {Id=337, Nome="Aceleração", Valor=84, IndiceJogador=51 },
            new EstatisticaJ {Id=338, Nome="Resistência", Valor=83, IndiceJogador=51 },
            new EstatisticaJ {Id=339, Nome="Força", Valor=54, IndiceJogador=51 },
            new EstatisticaJ {Id=340, Nome="Equilibrio", Valor=86, IndiceJogador=51 },
            new EstatisticaJ {Id=341, Nome="Sprint", Valor=74, IndiceJogador=51 },
            new EstatisticaJ {Id=342, Nome="Agilidade", Valor=88, IndiceJogador=51 },
            new EstatisticaJ {Id=343, Nome="Salto", Valor=66, IndiceJogador=51 },
           
             //Fonte
            new EstatisticaJ {Id=344, Nome="Aceleração", Valor=53, IndiceJogador=52 },
            new EstatisticaJ {Id=345, Nome="Resistência", Valor=76, IndiceJogador=52 },
            new EstatisticaJ {Id=346, Nome="Força", Valor=82, IndiceJogador=52 },
            new EstatisticaJ {Id=347, Nome="Equilibrio", Valor=54, IndiceJogador=52 },
            new EstatisticaJ {Id=348, Nome="Sprint", Valor=59, IndiceJogador=52 },
            new EstatisticaJ {Id=349, Nome="Agilidade", Valor=58, IndiceJogador=52 },
            new EstatisticaJ {Id=350, Nome="Salto", Valor=78, IndiceJogador=52 },

             //Pepe
            new EstatisticaJ {Id=351, Nome="Aceleração", Valor=68, IndiceJogador=53 },
            new EstatisticaJ {Id=352, Nome="Resistência", Valor=81, IndiceJogador=53 },
            new EstatisticaJ {Id=353, Nome="Força", Valor=84, IndiceJogador=53 },
            new EstatisticaJ {Id=354, Nome="Equilibrio", Valor=50, IndiceJogador=53 },
            new EstatisticaJ {Id=355, Nome="Sprint", Valor=75, IndiceJogador=53 },
            new EstatisticaJ {Id=356, Nome="Agilidade", Valor=64, IndiceJogador=53 },
            new EstatisticaJ {Id=357, Nome="Salto", Valor=78, IndiceJogador=53 },

             //Cedric
            new EstatisticaJ {Id=358, Nome="Aceleração", Valor=86, IndiceJogador=54 },
            new EstatisticaJ {Id=359, Nome="Resistência", Valor=88, IndiceJogador=54 },
            new EstatisticaJ {Id=360, Nome="Força", Valor=63, IndiceJogador=54 },
            new EstatisticaJ {Id=361, Nome="Equilibrio", Valor=83, IndiceJogador=54 },
            new EstatisticaJ {Id=362, Nome="Sprint", Valor=83, IndiceJogador=54 },
            new EstatisticaJ {Id=363, Nome="Agilidade", Valor=76, IndiceJogador=54 },
            new EstatisticaJ {Id=364, Nome="Salto", Valor=73, IndiceJogador=54 },

             //Patricio
            new EstatisticaJ {Id=365, Nome="Posic.", Valor=79, IndiceJogador=55 },
            new EstatisticaJ {Id=366, Nome="Mergulho GR", Valor=85, IndiceJogador=55 },
            new EstatisticaJ {Id=367, Nome="Jogo Mãos GR", Valor=82, IndiceJogador=55 },
            new EstatisticaJ {Id=368, Nome="Jogo Pés GR", Valor=85, IndiceJogador=55 },
            new EstatisticaJ {Id=369, Nome="Reflexos GR", Valor=83, IndiceJogador=55 },






             //---------------------------  ESPANHA  --------------------------------
            
            //COSTA
            new EstatisticaJ {Id=370, Nome="Cabeceamento", Valor=95, IndiceJogador=56 },
            new EstatisticaJ {Id=371, Nome="Pot. Remate", Valor=93, IndiceJogador=56 },
            new EstatisticaJ {Id=372, Nome="Finalização", Valor=94, IndiceJogador=56 },
            new EstatisticaJ {Id=373, Nome="Rem. Longe", Valor=90, IndiceJogador=56 },
            new EstatisticaJ {Id=374, Nome="Efeito", Valor=84, IndiceJogador=56 },
            new EstatisticaJ {Id=375, Nome="Prec. Livres", Valor=79, IndiceJogador=56 },
            new EstatisticaJ {Id=376, Nome="Penaltis", Valor=86, IndiceJogador=56 },
            new EstatisticaJ {Id=377, Nome="Remates de 1ª", Valor=77, IndiceJogador=56 },
                             
            //ISCO            
            new EstatisticaJ {Id=378, Nome="Aceleração", Valor=77, IndiceJogador=57 },
            new EstatisticaJ {Id=379, Nome="Resistência", Valor=86, IndiceJogador=57 },
            new EstatisticaJ {Id=380, Nome="Força", Valor=79, IndiceJogador=57 },
            new EstatisticaJ {Id=381, Nome="Equilibrio", Valor=72, IndiceJogador=57 },
            new EstatisticaJ {Id=382, Nome="Sprint", Valor=85, IndiceJogador=57 },
            new EstatisticaJ {Id=383, Nome="Agilidade", Valor=83, IndiceJogador=57 },
            new EstatisticaJ {Id=384, Nome="Salto", Valor=84, IndiceJogador=57 },
                              
            //D SILVA
            new EstatisticaJ {Id=385, Nome="Agressividade", Valor=66, IndiceJogador=58 },
            new EstatisticaJ {Id=386, Nome="Reflexos", Valor=84, IndiceJogador=58 },
            new EstatisticaJ {Id=387, Nome="Pos. Ataque", Valor=82, IndiceJogador=58 },
            new EstatisticaJ {Id=388, Nome="Interceções", Valor=77, IndiceJogador=58 },
            new EstatisticaJ {Id=389, Nome="Visão", Valor=85, IndiceJogador=58 },
            new EstatisticaJ {Id=390, Nome="Compostura", Valor=85, IndiceJogador=58 },
                              
            //INIESTA
            new EstatisticaJ {Id=391, Nome="Aceleração", Valor=64, IndiceJogador=59 },
            new EstatisticaJ {Id=392, Nome="Resistência", Valor=89, IndiceJogador=59 },
            new EstatisticaJ {Id=393, Nome="Força", Valor=62, IndiceJogador=59},
            new EstatisticaJ {Id=394, Nome="Equilibrio", Valor=67, IndiceJogador=59 },
            new EstatisticaJ {Id=395, Nome="Sprint", Valor=65, IndiceJogador=59 },
            new EstatisticaJ {Id=396, Nome="Agilidade", Valor=73, IndiceJogador=59 },
            new EstatisticaJ {Id=397, Nome="Salto", Valor=56, IndiceJogador=59 },
            
            //THIAGO
            new EstatisticaJ {Id=398, Nome="Aceleração", Valor=85, IndiceJogador=60 },
            new EstatisticaJ {Id=399, Nome="Resistência", Valor=69, IndiceJogador=60 },
            new EstatisticaJ {Id=400, Nome="Força", Valor=54, IndiceJogador=60 },
            new EstatisticaJ {Id=401, Nome="Equilibrio", Valor=84, IndiceJogador=60 },
            new EstatisticaJ {Id=402, Nome="Sprint", Valor=82, IndiceJogador=60 },
            new EstatisticaJ {Id=403, Nome="Agilidade", Valor=91, IndiceJogador=60 },
            new EstatisticaJ {Id=404, Nome="Salto", Valor=63, IndiceJogador=60 },

            //BUSQUETS
            new EstatisticaJ {Id=405, Nome="Aceleração", Valor=52, IndiceJogador=61 },
            new EstatisticaJ {Id=406, Nome="Resistência", Valor=84, IndiceJogador=61 },
            new EstatisticaJ {Id=407, Nome="Força", Valor=88, IndiceJogador=61 },
            new EstatisticaJ {Id=408, Nome="Equilibrio", Valor=50, IndiceJogador=61 },
            new EstatisticaJ {Id=409, Nome="Sprint", Valor=53, IndiceJogador=61 },
            new EstatisticaJ {Id=410, Nome="Agilidade", Valor=45, IndiceJogador=61 },
            new EstatisticaJ {Id=411, Nome="Salto", Valor=68, IndiceJogador=61 },
            
             //J ALBA
            new EstatisticaJ {Id=412, Nome="Aceleração", Valor=84, IndiceJogador=62 },
            new EstatisticaJ {Id=413, Nome="Resistência", Valor=83, IndiceJogador=62 },
            new EstatisticaJ {Id=414, Nome="Força", Valor=54, IndiceJogador=62 },
            new EstatisticaJ {Id=415, Nome="Equilibrio", Valor=86, IndiceJogador=62 },
            new EstatisticaJ {Id=416, Nome="Sprint", Valor=74, IndiceJogador=62 },
            new EstatisticaJ {Id=417, Nome="Agilidade", Valor=88, IndiceJogador=62 },
            new EstatisticaJ {Id=418, Nome="Salto", Valor=66, IndiceJogador=62 },
           
             //S RAMOS
            new EstatisticaJ {Id=419, Nome="Aceleração", Valor=53, IndiceJogador=63 },
            new EstatisticaJ {Id=420, Nome="Resistência", Valor=76, IndiceJogador=63 },
            new EstatisticaJ {Id=421, Nome="Força", Valor=82, IndiceJogador=63 },
            new EstatisticaJ {Id=422, Nome="Equilibrio", Valor=54, IndiceJogador=63 },
            new EstatisticaJ {Id=423, Nome="Sprint", Valor=59, IndiceJogador=63 },
            new EstatisticaJ {Id=424, Nome="Agilidade", Valor=58, IndiceJogador=63 },
            new EstatisticaJ {Id=425, Nome="Salto", Valor=78, IndiceJogador=63 },

             //PIQUE
            new EstatisticaJ {Id=426, Nome="Aceleração", Valor=68, IndiceJogador=64 },
            new EstatisticaJ {Id=427, Nome="Resistência", Valor=81, IndiceJogador=64 },
            new EstatisticaJ {Id=428, Nome="Força", Valor=84, IndiceJogador=64 },
            new EstatisticaJ {Id=429, Nome="Equilibrio", Valor=50, IndiceJogador=64 },
            new EstatisticaJ {Id=430, Nome="Sprint", Valor=75, IndiceJogador=64 },
            new EstatisticaJ {Id=431, Nome="Agilidade", Valor=64, IndiceJogador=64 },
            new EstatisticaJ {Id=432, Nome="Salto", Valor=78, IndiceJogador=64 },

             //CARVAJAL
            new EstatisticaJ {Id=433, Nome="Aceleração", Valor=86, IndiceJogador=65 },
            new EstatisticaJ {Id=434, Nome="Resistência", Valor=88, IndiceJogador=65 },
            new EstatisticaJ {Id=435, Nome="Força", Valor=63, IndiceJogador=65 },
            new EstatisticaJ {Id=436, Nome="Equilibrio", Valor=83, IndiceJogador=65 },
            new EstatisticaJ {Id=437, Nome="Sprint", Valor=83, IndiceJogador=65 },
            new EstatisticaJ {Id=438, Nome="Agilidade", Valor=76, IndiceJogador=65 },
            new EstatisticaJ {Id=439, Nome="Salto", Valor=73, IndiceJogador=65 },

             //DE GEA
            new EstatisticaJ {Id=440, Nome="Posic.", Valor=79, IndiceJogador=66 },
            new EstatisticaJ {Id=441, Nome="Mergulho GR", Valor=85, IndiceJogador=66 },
            new EstatisticaJ {Id=442, Nome="Jogo Mãos GR", Valor=82, IndiceJogador=66 },
            new EstatisticaJ {Id=443, Nome="Jogo Pés GR", Valor=85, IndiceJogador=66 },
            new EstatisticaJ {Id=444, Nome="Reflexos GR", Valor=83, IndiceJogador=66 },





             //---------------------------  IRAO  --------------------------------
            
            //AZMOUN
            new EstatisticaJ {Id=445, Nome="Cabeceamento", Valor=95, IndiceJogador=67 },
            new EstatisticaJ {Id=446, Nome="Pot. Remate", Valor=93, IndiceJogador=67 },
            new EstatisticaJ {Id=447, Nome="Finalização", Valor=94, IndiceJogador=67 },
            new EstatisticaJ {Id=448, Nome="Rem. Longe", Valor=90, IndiceJogador=67 },
            new EstatisticaJ {Id=449, Nome="Efeito", Valor=84, IndiceJogador=67 },
            new EstatisticaJ {Id=450, Nome="Prec. Livres", Valor=79, IndiceJogador=67 },
            new EstatisticaJ {Id=451, Nome="Penaltis", Valor=86, IndiceJogador=67 },
            new EstatisticaJ {Id=452,  Nome="Remates de 1ª", Valor=77, IndiceJogador=67 },
                             
            //TAREMI            
            new EstatisticaJ {Id=453, Nome="Aceleração", Valor=77, IndiceJogador=68 },
            new EstatisticaJ {Id=454, Nome="Resistência", Valor=86, IndiceJogador=68 },
            new EstatisticaJ {Id=455, Nome="Força", Valor=79, IndiceJogador=68 },
            new EstatisticaJ {Id=456, Nome="Equilibrio", Valor=72, IndiceJogador=68 },
            new EstatisticaJ {Id=457, Nome="Sprint", Valor=85, IndiceJogador=68 },
            new EstatisticaJ {Id=458, Nome="Agilidade", Valor=83, IndiceJogador=68 },
            new EstatisticaJ {Id=459, Nome="Salto", Valor=84, IndiceJogador=68 },
                              
            //AMIHI
            new EstatisticaJ {Id=460, Nome="Agressividade", Valor=66, IndiceJogador=69 },
            new EstatisticaJ {Id=461, Nome="Reflexos", Valor=84, IndiceJogador=69},
            new EstatisticaJ {Id=462, Nome="Pos. Ataque", Valor=82, IndiceJogador=69 },
            new EstatisticaJ {Id=463, Nome="Interceções", Valor=77, IndiceJogador=69 },
            new EstatisticaJ {Id=464, Nome="Visão", Valor=85, IndiceJogador=69 },
            new EstatisticaJ {Id=465, Nome="Compostura", Valor=85, IndiceJogador=69 },
                              
            //EBRAHIMI
            new EstatisticaJ {Id=466, Nome="Aceleração", Valor=64, IndiceJogador=70 },
            new EstatisticaJ {Id=467, Nome="Resistência", Valor=89, IndiceJogador=70 },
            new EstatisticaJ {Id=468, Nome="Força", Valor=62, IndiceJogador=70},
            new EstatisticaJ {Id=469, Nome="Equilibrio", Valor=67, IndiceJogador=70 },
            new EstatisticaJ {Id=470, Nome="Sprint", Valor=65, IndiceJogador=70 },
            new EstatisticaJ {Id=471, Nome="Agilidade", Valor=73, IndiceJogador=70 },
            new EstatisticaJ {Id=472, Nome="Salto", Valor=56, IndiceJogador=70 },
            
            //JAHANBAKHSH
            new EstatisticaJ {Id=473, Nome="Aceleração", Valor=85, IndiceJogador=71 },
            new EstatisticaJ {Id=474, Nome="Resistência", Valor=69, IndiceJogador=71 },
            new EstatisticaJ {Id=475, Nome="Força", Valor=54, IndiceJogador=71},
            new EstatisticaJ {Id=476, Nome="Equilibrio", Valor=84, IndiceJogador=71 },
            new EstatisticaJ {Id=477, Nome="Sprint", Valor=82, IndiceJogador=71 },
            new EstatisticaJ {Id=478, Nome="Agilidade", Valor=91, IndiceJogador=71 },
            new EstatisticaJ {Id=479, Nome="Salto", Valor=63, IndiceJogador=71 },

            //EZATOLAHI
            new EstatisticaJ {Id=480, Nome="Aceleração", Valor=52, IndiceJogador=72 },
            new EstatisticaJ {Id=481, Nome="Resistência", Valor=84, IndiceJogador=72 },
            new EstatisticaJ {Id=482, Nome="Força", Valor=88, IndiceJogador=72 },
            new EstatisticaJ {Id=483, Nome="Equilibrio", Valor=50, IndiceJogador=72 },
            new EstatisticaJ {Id=484, Nome="Sprint", Valor=53, IndiceJogador=72 },
            new EstatisticaJ {Id=485, Nome="Agilidade", Valor=45, IndiceJogador=72 },
            new EstatisticaJ {Id=486, Nome="Salto", Valor=68, IndiceJogador=72 },
            
             //SAFI
            new EstatisticaJ {Id=487, Nome="Aceleração", Valor=84, IndiceJogador=73 },
            new EstatisticaJ {Id=488, Nome="Resistência", Valor=83, IndiceJogador=73 },
            new EstatisticaJ {Id=489, Nome="Força", Valor=54, IndiceJogador=73 },
            new EstatisticaJ {Id=490, Nome="Equilibrio", Valor=86, IndiceJogador=73 },
            new EstatisticaJ {Id=491, Nome="Sprint", Valor=74, IndiceJogador=73 },
            new EstatisticaJ {Id=492, Nome="Agilidade", Valor=88, IndiceJogador=73 },
            new EstatisticaJ {Id=493, Nome="Salto", Valor=66, IndiceJogador=73 },
           
             //HOSSEINI
            new EstatisticaJ {Id=494, Nome="Aceleração", Valor=53, IndiceJogador=74 },
            new EstatisticaJ {Id=495, Nome="Resistência", Valor=76, IndiceJogador=74 },
            new EstatisticaJ {Id=496, Nome="Força", Valor=82, IndiceJogador=74 },
            new EstatisticaJ {Id=497, Nome="Equilibrio", Valor=54, IndiceJogador=74 },
            new EstatisticaJ {Id=498, Nome="Sprint", Valor=59, IndiceJogador=74 },
            new EstatisticaJ {Id=499, Nome="Agilidade", Valor=58, IndiceJogador=74 },
            new EstatisticaJ {Id=500, Nome="Salto", Valor=78, IndiceJogador=74 },

             //POURALIGANJI
            new EstatisticaJ {Id=501, Nome="Aceleração", Valor=68, IndiceJogador=75 },
            new EstatisticaJ {Id=502, Nome="Resistência", Valor=81, IndiceJogador=75 },
            new EstatisticaJ {Id=503, Nome="Força", Valor=84, IndiceJogador=75 },
            new EstatisticaJ {Id=504, Nome="Equilibrio", Valor=50, IndiceJogador=75 },
            new EstatisticaJ {Id=505, Nome="Sprint", Valor=75, IndiceJogador=75 },
            new EstatisticaJ {Id=506, Nome="Agilidade", Valor=64, IndiceJogador=75 },
            new EstatisticaJ {Id=507, Nome="Salto", Valor=78, IndiceJogador=75 },

             //REZAEIAN
            new EstatisticaJ {Id=508, Nome="Aceleração", Valor=86, IndiceJogador=76 },
            new EstatisticaJ {Id=509, Nome="Resistência", Valor=88, IndiceJogador=76 },
            new EstatisticaJ {Id=510, Nome="Força", Valor=63, IndiceJogador=76 },
            new EstatisticaJ {Id=511, Nome="Equilibrio", Valor=83, IndiceJogador=76 },
            new EstatisticaJ {Id=512, Nome="Sprint", Valor=83, IndiceJogador=76 },
            new EstatisticaJ {Id=513, Nome="Agilidade", Valor=76, IndiceJogador=76 },
            new EstatisticaJ {Id=514, Nome="Salto", Valor=73, IndiceJogador=76 },

             //BEIRANVAND
            new EstatisticaJ {Id=515, Nome="Posic.", Valor=79, IndiceJogador=77 },
            new EstatisticaJ {Id=516, Nome="Mergulho GR", Valor=85, IndiceJogador=77 },
            new EstatisticaJ {Id=517, Nome="Jogo Mãos GR", Valor=82, IndiceJogador=77 },
            new EstatisticaJ {Id=518, Nome="Jogo Pés GR", Valor=85, IndiceJogador=77 },
            new EstatisticaJ {Id=519, Nome="Reflexos GR", Valor=83, IndiceJogador=77 },







             //---------------------------  Marrocos  --------------------------------
            
            //Boutaib
            new EstatisticaJ {Id=520, Nome="Cabeceamento", Valor=95, IndiceJogador=78 },
            new EstatisticaJ {Id=521, Nome="Pot. Remate", Valor=93, IndiceJogador=78 },
            new EstatisticaJ {Id=522, Nome="Finalização", Valor=94, IndiceJogador=78 },
            new EstatisticaJ {Id=523, Nome="Rem. Longe", Valor=90, IndiceJogador=78},
            new EstatisticaJ {Id=524, Nome="Efeito", Valor=84, IndiceJogador=78 },
            new EstatisticaJ {Id=525, Nome="Prec. Livres", Valor=79, IndiceJogador=78 },
            new EstatisticaJ {Id=526, Nome="Penaltis", Valor=86, IndiceJogador=78 },
            new EstatisticaJ {Id=527,  Nome="Remates de 1ª", Valor=77, IndiceJogador=78 },
                             
            //Ziyach            
            new EstatisticaJ {Id=528, Nome="Aceleração", Valor=77, IndiceJogador=79 },
            new EstatisticaJ {Id=529, Nome="Resistência", Valor=86, IndiceJogador=79 },
            new EstatisticaJ {Id=530, Nome="Força", Valor=79, IndiceJogador=79 },
            new EstatisticaJ {Id=531, Nome="Equilibrio", Valor=72, IndiceJogador=79 },
            new EstatisticaJ {Id=532, Nome="Sprint", Valor=85, IndiceJogador=79 },
            new EstatisticaJ {Id=533, Nome="Agilidade", Valor=83, IndiceJogador=79 },
            new EstatisticaJ {Id=534, Nome="Salto", Valor=84, IndiceJogador=79 },
                              
            //Amrabat
            new EstatisticaJ {Id=535, Nome="Agressividade", Valor=66, IndiceJogador=80 },
            new EstatisticaJ {Id=536, Nome="Reflexos", Valor=84, IndiceJogador=80},
            new EstatisticaJ {Id=537, Nome="Pos. Ataque", Valor=82, IndiceJogador=80 },
            new EstatisticaJ {Id=538, Nome="Interceções", Valor=77, IndiceJogador=80 },
            new EstatisticaJ {Id=539, Nome="Visão", Valor=85, IndiceJogador=80 },
            new EstatisticaJ {Id=540, Nome="Compostura", Valor=85, IndiceJogador=80 },
                             
            //Belhanda
            new EstatisticaJ {Id=541, Nome="Aceleração", Valor=64, IndiceJogador=81 },
            new EstatisticaJ {Id=542, Nome="Resistência", Valor=89, IndiceJogador=81 },
            new EstatisticaJ {Id=543, Nome="Força", Valor=62, IndiceJogador=81},
            new EstatisticaJ {Id=544, Nome="Equilibrio", Valor=67, IndiceJogador=81 },
            new EstatisticaJ {Id=545, Nome="Sprint", Valor=65, IndiceJogador=81 },
            new EstatisticaJ {Id=546, Nome="Agilidade", Valor=73, IndiceJogador=81 },
            new EstatisticaJ {Id=547, Nome="Salto", Valor=56, IndiceJogador=81 },
            
            //Boussoufa
            new EstatisticaJ {Id=548, Nome="Aceleração", Valor=85, IndiceJogador=82 },
            new EstatisticaJ {Id=549, Nome="Resistência", Valor=69, IndiceJogador=82 },
            new EstatisticaJ {Id=550, Nome="Força", Valor=54, IndiceJogador=82},
            new EstatisticaJ {Id=551, Nome="Equilibrio", Valor=84, IndiceJogador=82 },
            new EstatisticaJ {Id=552, Nome="Sprint", Valor=82, IndiceJogador=82 },
            new EstatisticaJ {Id=553, Nome="Agilidade", Valor=91, IndiceJogador=82 },
            new EstatisticaJ {Id=554, Nome="Salto", Valor=63, IndiceJogador=82 },

            //Ahmadi
            new EstatisticaJ {Id=555, Nome="Aceleração", Valor=52, IndiceJogador=83 },
            new EstatisticaJ {Id=556, Nome="Resistência", Valor=84, IndiceJogador=83 },
            new EstatisticaJ {Id=557, Nome="Força", Valor=88, IndiceJogador=83},
            new EstatisticaJ {Id=558, Nome="Equilibrio", Valor=50, IndiceJogador=83 },
            new EstatisticaJ {Id=559, Nome="Sprint", Valor=53, IndiceJogador=83 },
            new EstatisticaJ {Id=560, Nome="Agilidade", Valor=45, IndiceJogador=83 },
            new EstatisticaJ {Id=561, Nome="Salto", Valor=68, IndiceJogador=83 },
            
             //Hakimi
            new EstatisticaJ {Id=562, Nome="Aceleração", Valor=84, IndiceJogador=84},
            new EstatisticaJ {Id=563, Nome="Resistência", Valor=83, IndiceJogador=84 },
            new EstatisticaJ {Id=564, Nome="Força", Valor=54, IndiceJogador=84 },
            new EstatisticaJ {Id=565, Nome="Equilibrio", Valor=86, IndiceJogador=84 },
            new EstatisticaJ {Id=566, Nome="Sprint", Valor=74, IndiceJogador=84 },
            new EstatisticaJ {Id=567, Nome="Agilidade", Valor=88, IndiceJogador=84 },
            new EstatisticaJ {Id=568, Nome="Salto", Valor=66, IndiceJogador=84 },
           
             //Saiss
            new EstatisticaJ {Id=569, Nome="Aceleração", Valor=53, IndiceJogador=85 },
            new EstatisticaJ {Id=570, Nome="Resistência", Valor=76, IndiceJogador=85 },
            new EstatisticaJ {Id=571, Nome="Força", Valor=82, IndiceJogador=85},
            new EstatisticaJ {Id=572, Nome="Equilibrio", Valor=54, IndiceJogador=85 },
            new EstatisticaJ {Id=573, Nome="Sprint", Valor=59, IndiceJogador=85 },
            new EstatisticaJ {Id=574, Nome="Agilidade", Valor=58, IndiceJogador=85 },
            new EstatisticaJ {Id=575, Nome="Salto", Valor=78, IndiceJogador=85 },

             //Benatia
            new EstatisticaJ {Id=576, Nome="Aceleração", Valor=68, IndiceJogador=86 },
            new EstatisticaJ {Id=577, Nome="Resistência", Valor=81, IndiceJogador=86 },
            new EstatisticaJ {Id=578, Nome="Força", Valor=84, IndiceJogador=86},
            new EstatisticaJ {Id=579, Nome="Equilibrio", Valor=50, IndiceJogador=86 },
            new EstatisticaJ {Id=580, Nome="Sprint", Valor=75, IndiceJogador=86 },
            new EstatisticaJ {Id=581, Nome="Agilidade", Valor=64, IndiceJogador=86 },
            new EstatisticaJ {Id=582, Nome="Salto", Valor=78, IndiceJogador=86 },

             //Dirar
            new EstatisticaJ {Id=583, Nome="Aceleração", Valor=86, IndiceJogador=87 },
            new EstatisticaJ {Id=584, Nome="Resistência", Valor=88, IndiceJogador=87 },
            new EstatisticaJ {Id=585, Nome="Força", Valor=63, IndiceJogador=87 },
            new EstatisticaJ {Id=586, Nome="Equilibrio", Valor=83, IndiceJogador=87 },
            new EstatisticaJ {Id=587, Nome="Sprint", Valor=83, IndiceJogador=87 },
            new EstatisticaJ {Id=588, Nome="Agilidade", Valor=76, IndiceJogador=87 },
            new EstatisticaJ {Id=589, Nome="Salto", Valor=73, IndiceJogador=87 },

             //Kajoui
            new EstatisticaJ {Id=590, Nome="Posic.", Valor=79, IndiceJogador=88 },
            new EstatisticaJ {Id=591, Nome="Mergulho GR", Valor=85, IndiceJogador=88 },
            new EstatisticaJ {Id=592, Nome="Jogo Mãos GR", Valor=82, IndiceJogador=88 },
            new EstatisticaJ {Id=593, Nome="Jogo Pés GR", Valor=85, IndiceJogador=88},
            new EstatisticaJ {Id=594, Nome="Reflexos GR", Valor=83, IndiceJogador=88 },


            };
            estatisticaJ.ForEach(aa => context.EstatisticaJ.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();



            //adicionar estatistica das selecoes
            var estatisticaS = new List<EstatisticaS> {

                //Inglaterra
                new EstatisticaS {Id=1, Nome="Ataque", Valor="83", IndiceSelecao=5 },
                new EstatisticaS {Id=2, Nome="Meio-Campo", Valor="81", IndiceSelecao=5 },
                new EstatisticaS {Id=3, Nome="Defesa", Valor="80", IndiceSelecao=5 },
                new EstatisticaS {Id=4, Nome="Capitão", Valor="Harry Kane", IndiceSelecao=5 },
                new EstatisticaS {Id=5, Nome="Avaliação Geral", Valor="4,5", IndiceSelecao=5 },

                //Belgica
                new EstatisticaS {Id=6, Nome="Ataque", Valor="85", IndiceSelecao=6 },
                new EstatisticaS {Id=7, Nome="Meio-Campo", Valor="83", IndiceSelecao=6 },
                new EstatisticaS {Id=8, Nome="Defesa", Valor="83", IndiceSelecao=6 },
                new EstatisticaS {Id=9, Nome="Capitão", Valor="Hazard", IndiceSelecao=6 },
                new EstatisticaS {Id=10, Nome="Avaliação Geral", Valor="5", IndiceSelecao=6},

                //Tunisia
                new EstatisticaS {Id=11, Nome="Ataque", Valor="75", IndiceSelecao=7 },
                new EstatisticaS {Id=12, Nome="Meio-Campo", Valor="71", IndiceSelecao=7 },
                new EstatisticaS {Id=13, Nome="Defesa", Valor="71", IndiceSelecao=7},
                new EstatisticaS {Id=14, Nome="Capitão", Valor="Khazri", IndiceSelecao=7 },
                new EstatisticaS {Id=15, Nome="Avaliação Geral", Valor="3,5", IndiceSelecao=7 },
                
                //Panama
                new EstatisticaS {Id=16, Nome="Ataque", Valor="68", IndiceSelecao=8 },
                new EstatisticaS {Id=17, Nome="Meio-Campo", Valor="68", IndiceSelecao=8 },
                new EstatisticaS {Id=18, Nome="Defesa", Valor="68", IndiceSelecao=8 },
                new EstatisticaS {Id=19, Nome="Capitão", Valor="Torres", IndiceSelecao=8 },
                new EstatisticaS {Id=20, Nome="Avaliação Geral", Valor="3", IndiceSelecao=8 },

                //Portugal
                new EstatisticaS {Id=21, Nome="Ataque", Valor="88", IndiceSelecao=1 },
                new EstatisticaS {Id=22, Nome="Meio-Campo", Valor="83", IndiceSelecao=1 },
                new EstatisticaS {Id=23, Nome="Defesa", Valor="82", IndiceSelecao=1 },
                new EstatisticaS {Id=24, Nome="Capitão", Valor="C.Ronaldo", IndiceSelecao=1},
                new EstatisticaS {Id=25, Nome="Avaliação Geral", Valor="5", IndiceSelecao=1 },

                //Espanha
                new EstatisticaS {Id=26, Nome="Ataque", Valor="84", IndiceSelecao=2 },
                new EstatisticaS {Id=27, Nome="Meio-Campo", Valor="86", IndiceSelecao=2 },
                new EstatisticaS {Id=28, Nome="Defesa", Valor="85", IndiceSelecao=2 },
                new EstatisticaS {Id=29, Nome="Capitão", Valor="S.Ramos", IndiceSelecao=2 },
                new EstatisticaS {Id=30, Nome="Avaliação Geral", Valor="5", IndiceSelecao=2 },

                //Irao
                new EstatisticaS {Id=31, Nome="Ataque", Valor="76", IndiceSelecao=3 },
                new EstatisticaS {Id=32, Nome="Meio-Campo", Valor="71", IndiceSelecao=3 },
                new EstatisticaS {Id=33, Nome="Defesa", Valor="71", IndiceSelecao=3 },
                new EstatisticaS {Id=34, Nome="Capitão", Valor="H.Safi", IndiceSelecao=3 },
                new EstatisticaS {Id=35, Nome="Avaliação Geral", Valor="3,5", IndiceSelecao=3 },

                //Marrocos
                new EstatisticaS {Id=36, Nome="Ataque", Valor="74", IndiceSelecao=4 },
                new EstatisticaS {Id=37, Nome="Meio-Campo", Valor="77", IndiceSelecao=4 },
                new EstatisticaS {Id=38, Nome="Defesa", Valor="77", IndiceSelecao=4 },
                new EstatisticaS {Id=39, Nome="Capitão", Valor="Benatia", IndiceSelecao=4 },
                new EstatisticaS {Id=40, Nome="Avaliação Geral", Valor="4", IndiceSelecao=4 },
            };
            estatisticaS.ForEach(aa => context.EstatisticaS.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();

            //adicionar Equipamentos
            var equipamentos = new List<Equipamentos> {

            //Inglaterra
            new Equipamentos {Id=1, Imagem="InglaterraPrin.png", Nome="Principal", idSelecao=5},
            new Equipamentos {Id=2, Imagem="InglaterraSec.png", Nome="Secundário", idSelecao=5},
            new Equipamentos {Id=3, Imagem="InglaterraGR.png", Nome="Guarda-Redes", idSelecao=5},

            //Bélgica
            new Equipamentos {Id=4, Imagem="BelgicaPrin.png", Nome="Principal", idSelecao=6},
            new Equipamentos {Id=5, Imagem="BelgicaSec.png", Nome="Secundário", idSelecao=6},
            new Equipamentos {Id=6, Imagem="BelgicaGR.png", Nome="Guarda-Redes", idSelecao=6},

            //Tunísia
            new Equipamentos {Id=7, Imagem="TunisiaPrin.png", Nome="Principal", idSelecao=7},
            new Equipamentos {Id=8, Imagem="TunisiaSec.png", Nome="Secundário", idSelecao=7},
            new Equipamentos {Id=9, Imagem="TunisiaGR.png", Nome="Guarda-Redes", idSelecao=7},
            
            //Panamá
            new Equipamentos {Id=10, Imagem="PanamaPrin.png", Nome="Principal", idSelecao=8},
            new Equipamentos {Id=11, Imagem="PanamaSec.png", Nome="Secundário", idSelecao=8},
            new Equipamentos {Id=12, Imagem="PanamaGR.png", Nome="Guarda-Redes", idSelecao=8},

            //Portugal
            new Equipamentos {Id=13, Imagem="PortugalPrin.png", Nome="Principal", idSelecao=1},
            new Equipamentos {Id=14, Imagem="PortugalSec.png", Nome="Secundário", idSelecao=1},
            new Equipamentos {Id=15, Imagem="PortugalGR.png", Nome="Guarda-Redes", idSelecao=1},

            //Espanha
            new Equipamentos {Id=16, Imagem="EspanhaPrin.png", Nome="Principal", idSelecao=2},
            new Equipamentos {Id=17, Imagem="EspanhaSec.png", Nome="Secundário", idSelecao=2},
            new Equipamentos {Id=18, Imagem="EspanhaGR.png", Nome="Guarda-Redes", idSelecao=2},

            //Irão
            new Equipamentos {Id=19, Imagem="IraoPrin.png", Nome="Principal", idSelecao=3},
            new Equipamentos {Id=20, Imagem="IraoSec.png", Nome="Secundário", idSelecao=3},
            new Equipamentos {Id=21, Imagem="IraoGR.png", Nome="Guarda-Redes", idSelecao=3},
            
            //Marrocos
            new Equipamentos {Id=22, Imagem="MarrocosPrin.png", Nome="Principal", idSelecao=4},
            new Equipamentos {Id=23, Imagem="MarrocosSec.png", Nome="Secundário", idSelecao=4},
            new Equipamentos {Id=24, Imagem="MarrocosGR.png", Nome="Guarda-Redes", idSelecao=4},

            };
            equipamentos.ForEach(aa => context.Equipamentos.AddOrUpdate(a => a.Id, aa));
            context.SaveChanges();


        }
    }
}
