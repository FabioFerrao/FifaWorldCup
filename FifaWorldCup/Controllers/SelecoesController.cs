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
                selecao.EstatisticaS,
                selecao.Emblema,
                selecao.Equipamentos,
                selecao.Jogadores
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
