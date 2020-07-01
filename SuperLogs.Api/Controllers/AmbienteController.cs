using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperLogs.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AmbienteController : ControllerBase
    {
        private readonly IAmbienteService _ambiente;

        public AmbienteController(IAmbienteService ambiente)
        {
            _ambiente = ambiente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ambiente>> Get()
        {
            return _ambiente.ListarTodos();
        }

        [HttpGet("{id}")]
        public ActionResult<Ambiente> Get(int id)
        {
            var ambiente = _ambiente.ObterPorId(id);
            if (ambiente == null)
            {
                return NotFound();
            }
            return ambiente;
        }

        [HttpPost]
        public ActionResult Post([FromBody]Ambiente ambiente)
        {
            return Ok(_ambiente.Salvar(ambiente));
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ambiente ambiente)
        {
            if (id != ambiente.IdAmbiente)
            {
                return BadRequest();
            }
            return Ok(_ambiente.Atualizar(ambiente));
        }

        [HttpDelete("{id}")]
        public ActionResult<Ambiente> Delete(int id)
        {
            var ambienteEncontrado = _ambiente.Deletar(id);
            if(ambienteEncontrado == false)
            {
                return NotFound();
            }
            return Ok();
        }

    }
}