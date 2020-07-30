using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Transport;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperLogs.Service
{
    public class LogService : ILogService
    {
        private AppDbContext _context;

        public LogService(AppDbContext context)
        {
            _context = context;
        }

        public IList<Log> BuscaPorData(DateTime data)
        {
            return _context.Log.Where(log => log.Data == data).ToList();
        }

        public IList<Log> BuscaPorEventos(int eventos)
        {
           return _context.Log.Where(log => log.Eventos == eventos).ToList();
        }

        public IList<Log> BuscaPorHostName(string hostName)
        {
           return _context.Log.Where(log => log.Host == hostName).ToList();
        }

        public Log BuscaPorId(int id)
        {
            return _context.Log.FirstOrDefault(log => log.IdLog == id);
        }

        public IList<Log> BuscaPorIdAmbiente(int idAmbiente)
        {
            return _context.Log.Where(log => log.IdAmbiente == idAmbiente).ToList();
        }

        public IList<Log> BuscaPorIdStatus(int idStatus)
        {
            return _context.Log.Where(log => log.IdStatus == idStatus).ToList();
        }

        public IList<Log> BuscaPorIdTipoLog(int idTipoLog)
        {
            return _context.Log.Where(log => log.IdTipoLog == idTipoLog).ToList();
        }

        public IList<Log> BuscaPorIdUsuario(int idUsuario)
        {
            return _context.Log.Where(log => log.IdUsuario == idUsuario).ToList();
        }

        public IList<Log> BuscaPorTitulo(string titulo)
        {
            return _context.Log.Where(log => log.Titulo.Contains(titulo)).ToList();
        }

        public void Criar(CriarLogDto log)
        {
            var logModel = ParaLog(log);
            _context.Log.Add(logModel);
            _context.SaveChanges();

            log.IdLog = logModel.IdLog;
        }

        public CriarLogDto Atualizar(CriarLogDto log)
        {
            var logModel = ParaLog(log);
            _context.Log.Update(logModel);
            _context.SaveChanges();

            return log;
        }

        public bool Deletar(int id)
        {
            var log = BuscaPorId(id);
            if (log == null)
            {
                return false;
            }

            _context.Log.Remove(log);
            _context.SaveChanges();

            return true;
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
