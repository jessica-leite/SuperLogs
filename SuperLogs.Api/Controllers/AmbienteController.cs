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
        private readonly AppDbContext _database;
        private readonly IAmbienteService _ambiente;

        public AmbienteController(AppDbContext database, IAmbienteService ambiente)
        {
            _database = database;
            _ambiente = ambiente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ambiente>> Get()
        {
            return _database.Ambiente.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Ambiente> Get(int id)
        {
            var ambiente = _database.Ambiente.Find(id); 
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
            _database.Entry(ambiente).State = EntityState.Modified;
            _database.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Ambiente> Delete(int id)
        {
            var ambiente = _database.Ambiente.Find(id);
            if(ambiente == null)
            {
                return NotFound();
            }
            _database.Ambiente.Remove(ambiente);
            _database.SaveChanges();
            return ambiente;
        }

        [HttpGet("logs")]
        public ActionResult<IEnumerable<Ambiente>> GetAmbienteLogs()
        {
            return _database.Ambiente.Include(x => x.Logs).ToList();
        }

    }
}