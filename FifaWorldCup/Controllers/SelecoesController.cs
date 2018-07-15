using FifaWorldCup.API;
using FifaWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FifaWorldCup.Controllers
{
    public class SelecoesController : ApiController
    {
        private FifaDB db = new FifaDB();

        [HttpGet, Route("api/Selecao/{id:int}")]
        public IHttpActionResult GetSelecao(int id)
        {
            var result = db.Selecoes
                .Where(selecao => selecao.Id == id).Select(selecao => new GetDetalhesDaSelecao
                {  //{ } permite definir um objeto anonimo( sem class) em .net                  
                    Id = selecao.Id,
                    Nome = selecao.Nome,
                    Emblema = selecao.Emblema,
                    ImagemPosicoes = selecao.ImagemPosicoes,
                    listaDeJogadoresPorSelecao = selecao.Jogadores
                    .Select(j => new GetDetalhesDaSelecao.JogadoresDaSelecao
                    {
                        Id = j.Id,
                        Nome = j.Nome,
                        Imagem = j.Imagem,
                        Posicao = j.Posicao
                    })
                    .ToList(),

                    listaDeEstatisticaPorSelecao = selecao.EstatisticaS
                    .Select(k => new GetDetalhesDaSelecao.EstatisticaDaSelecao
                    {
                        Id = k.Id,
                        Nome = k.Nome,
                        Valor = k.Valor
                    })
                    .ToList(),

                    listaDeEquipamentosPorSelecao = selecao.Equipamentos
                    .Select(q => new GetDetalhesDaSelecao.EquipamentosDaSelecao
                    {
                        Id = q.Id,
                        Nome = q.Nome,
                        Imagem = q.Imagem
                    })
                    .ToList(),

                })
                .ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
