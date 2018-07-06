using FifaWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FifaWorldCup.Controllers
{
    public class GruposController : ApiController
    {
        private FifaDB db = new FifaDB();
        [HttpGet, Route("api/Grupos")]
        public IHttpActionResult GetGrupos()
        {
            var result = db.Grupos.Select(grupo => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net
                grupo.Id,
                grupo.Nome,
                grupo.Selecoes

            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
