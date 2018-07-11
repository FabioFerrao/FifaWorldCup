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
    public class GruposController : ApiController
    {

        private FifaDB db = new FifaDB();


        [HttpGet, Route("api/Grupos")]
        public IHttpActionResult GetGrupos()
        {
            var result = db.Grupos.Select(grupo => new GetGrupos
            {  //{ } permite definir um objeto anonimo( sem class) em .net
                Id = grupo.Id,
                Nome = grupo.Nome

            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/Grupo/{id:int}")]
        public IHttpActionResult GetGrupo(int id)
        {
            var result = db.Grupos.Where(grupo => grupo.Id == id).Select(grupo => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net
                grupo.Id,
                grupo.Nome,

            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }


        [HttpGet, Route("api/Grupo/{id:int}/Selecoes")]
        public IHttpActionResult GetGruposSelecoes(int id)
        {
            var result = db.Selecoes
            .Where(selecao => selecao.IndiceGrupo == id)
            .Select(selecao => new GetSelecoes 
            {  //{ } permite definir um objeto anonimo( sem class) em .net  
                Id = selecao.Id,
                Nome = selecao.Nome,
                Emblema = selecao.Emblema,
                IndiceGrupo= selecao.IndiceGrupo
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }
    }
}
