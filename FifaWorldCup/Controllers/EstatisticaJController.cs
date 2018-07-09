using FifaWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FifaWorldCup.Controllers
{
    public class EstatisticaJController : ApiController
    {
        private FifaDB db = new FifaDB();
        [HttpGet, Route("api/EstatisticaJs")]
        public IHttpActionResult GetEstatisticaJs()
        {
            var result = db.EstatisticaJ.Select(estatisticaJ => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net
               estatisticaJ.Id,
               estatisticaJ.Nome,
               estatisticaJ.Valor,
               estatisticaJ.IndiceJogador
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/EstatisticaJ/{id:int}")]
        public IHttpActionResult GetEstatisticaJ(int id)
        {
            var result = db.EstatisticaJ.Where(estatisticaJ => estatisticaJ.Id == id).Select(estatisticaJ => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net                
                estatisticaJ.Id,
                estatisticaJ.Nome,
                estatisticaJ.Valor,
                estatisticaJ.IndiceJogador
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
