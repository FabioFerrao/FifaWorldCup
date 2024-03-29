﻿using FifaWorldCup.API;
using FifaWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FifaWorldCup.Controllers
{
    public class JogadoresController : ApiController
    {
        private FifaDB db = new FifaDB();

        [HttpGet, Route("api/Jogador/{id:int}")]
        public IHttpActionResult GetJogador(int id)
        {
            var result = db.Jogadores
                .Where(jogador => jogador.Id == id).Select(jogador => new GetDetalhesDoJogador
                {  
                    Id = jogador.Id,
                    Nome =  jogador.Nome,
                    Imagem = jogador.Imagem,
                    Posicao = jogador.Posicao,
                    PosicaoImagem = jogador.PosicaoImagem,
                    listaDeEstatisticaPorJogador = jogador.EstatisticaJ
                       .Select(k => new GetDetalhesDoJogador.EstatisticaDoJogador
                        {
                            Id = k.Id,
                            Nome = k.Nome,
                            Valor = k.Valor
                        })
                        .ToList(),
                }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
