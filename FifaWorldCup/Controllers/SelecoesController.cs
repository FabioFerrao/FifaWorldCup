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

        [HttpGet, Route("api/Selecoes")]
        public IHttpActionResult GetSelecoes()
        {
            var result = db.Selecoes.Select(selecao => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net
                selecao.Id,
                selecao.Nome,
                selecao.Emblema,
                selecao.IndideGrupo
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/Selecao/{id:int}")]
        public IHttpActionResult GetSelecao(int id)
        {
            var result = db.Selecoes.Where(selecao => selecao.Id == id).Select(selecao => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net                  
                selecao.Id,
                selecao.Nome,
                selecao.Emblema,
                selecao.IndideGrupo
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/Selecao/{id:int}/Jogadores")]
        public IHttpActionResult GetSelecaoJogadores(int id)
        {
            var result = db.Jogadores.Where(jogador => jogador.IndiceSelecao == id).Select(jogador => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net          
                jogador.Id,
                jogador.Nome,
                jogador.Imagem,
                jogador.Posicao,
                jogador.IndiceSelecao
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
        [HttpGet, Route("api/Selecao/{id:int}/Estatistica")]
        public IHttpActionResult GetEstatisticaSelecao(int id)
        {
            var result = db.EstatisticaS.Where(estatisticaS => estatisticaS.IndiceSelecao == id).Select(estatisticaS => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net          
                estatisticaS.Id,
                estatisticaS.Nome,
                estatisticaS.Valor,
                estatisticaS.IndiceSelecao
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/Selecao/{id:int}/Equipamentos")]
        public IHttpActionResult GetEquipamentosSelecao(int id)
        {
            var result = db.Equipamentos.Where(equipamento => equipamento.idSelecao == id).Select(equipamento => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net          
                equipamento.Id,
                equipamento.Nome,
                equipamento.Imagem,
                equipamento.idSelecao
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
