using Microsoft.AspNetCore.Mvc;
using SuperLogs.Service;
using SuperLogs.Transport;

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

        [HttpGet]
        public ActionResult Get(int id)
        {
            var log = _logService.BuscaPorId(id);
            if (log == null)
            {
                return NotFound();
            }

            return Ok(log);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CriarLogDto log)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(log);
            }

            _logService.Criar(log);

            var uri = Url.Action("Recuperar", new { id = log.IdLog });
            return Created(uri, log);
        }

        [HttpPut]
        public ActionResult Update([FromBody] CriarLogDto log)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(log);
            }

            _logService.Atualizar(log);

            return Ok(log);
        }
    }
}
