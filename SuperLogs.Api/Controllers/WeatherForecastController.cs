using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperLogs.Model;
using SuperLogs.Model.Context;

namespace SuperLogs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly AppDbContext _context;
        public WeatherForecastController(AppDbContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Log>> Get()
        {
            //Teste de insert e select no banco
            //_context.Log.Add(new Log()
            //{
            //    Titulo = "Titulo log",
            //    Descricao = "descrição log",
            //    Eventos = 100,
            //    Host = "linkhost",
            //    Data = new DateTime(),
            //    IdStatus = 1,
            //    IdAmbiente = 1,
            //    IdTipoLog = 1,
            //    IdUsuario = 1
            //});
            //_context.SaveChanges();
            return _context.Log.ToList();
        }
    }
}
