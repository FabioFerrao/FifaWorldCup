using FifaWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FifaWorldCup.Controllers
{
    public class EquipamentosController : ApiController
    {
        private FifaDB db = new FifaDB();
        [HttpGet, Route("api/Equipamentos")]
        public IHttpActionResult GetEquipamentos()
        {
            var result = db.Equipamentos.Select(equipamento => new
            {  //{ } permite definir um objeto anonimo( sem class) em .net
                equipamento.Id,
                equipamento.Nome,
                equipamento.Imagem,
                equipamento.idSelecao
            }).ToList(); //guarda o resultado da query numa lista

            //codigo 200 ok com JSON resultante (array dos objetos que representam os grupos)
            return Ok(result);
        }

        [HttpGet, Route("api/Equipamento/{id:int}")]
        public IHttpActionResult GetEquipamento(int id)
        {
            var result = db.Equipamentos.Where(equipamento => equipamento.Id == id).Select(equipamento => new
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
