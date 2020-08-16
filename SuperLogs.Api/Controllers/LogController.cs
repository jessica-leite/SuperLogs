using Microsoft.AspNetCore.Mvc;
using SuperLogs.Service;
using SuperLogs.Transport;
using SuperLogs.Transport.DTOs;

namespace SuperLogs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly LogService _logService;

        public LogController(LogService service)
        {
            _logService = service;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var log = _logService.BuscaPorId(id);
            if (log == null)
            {
                return NotFound();
            }

            return Ok(log);
        }

        [HttpGet]
        public ActionResult GetAllByFilter([FromQuery] FiltroLogDto filtro)
        {
            var logs = _logService.BuscaPorFiltro(filtro);

            return Ok(logs);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CriarLogDto log)
        {
            _logService.Criar(log);

            return Ok();
        }

        [HttpPut]
        public ActionResult Update([FromBody] CriarLogDto log)
        {
            _logService.Atualizar(log);

            return Ok(log);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var excluido = _logService.Deletar(id);

            if (excluido)
            {
                return NoContent();
            }
            
            return NotFound();
        }
    }
}
