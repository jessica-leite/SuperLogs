using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Transport;
using System.Collections.Generic;

namespace SuperLogs.Service
{
    public class LogService : ILogService
    {
        private AppDbContext _context;

        public LogService(AppDbContext context)
        {
            _context = context;
        }

        public IList<Log> BuscaPorData(int data)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorEventos(int eventos)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorHostName(string hostName)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorIdAmbiente(int idAmbiente)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorIdStatus(int idStatus)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorIdTipoLog(int idTipoLog)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorIdUsuario(int idUsuario)
        {
            throw new System.NotImplementedException();
        }

        public IList<Log> BuscaPorTitulo(string titulo)
        {
            throw new System.NotImplementedException();
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
