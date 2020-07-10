using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Transport;

namespace SuperLogs.Service
{
    public class LogService
    {
        private AppDbContext _context;

        public LogService(AppDbContext context)
        {
            _context = context;
        }
        public void Criar(CriarLogDto log)
        {
            _context.Log.Add(ParaLog(log));
            _context.SaveChanges();
        }

        private Log ParaLog(CriarLogDto log)
        {
            return new Log
            {
                IdLog = log.IdLog,
                Data = log.Data,
                Descricao = log.Descricao,
                Eventos = log.Eventos,
                Host = log.Host,
                IdAmbiente = log.IdAmbiente,
                IdStatus = log.IdStatus,
                IdTipoLog = log.IdTipoLog,
                IdUsuario = log.IdUsuario,
                Titulo = log.Titulo
            };
        }
    }
}
