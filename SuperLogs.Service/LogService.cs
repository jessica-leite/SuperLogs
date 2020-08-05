using Microsoft.EntityFrameworkCore;
using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Transport;
using SuperLogs.Transport.DTOs;
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

        public IList<Log> BuscaPorFiltro(FiltroLogDto filtro)
        {
            var query = _context.Log.Where(log => log.IdAmbiente == filtro.IdAmbiente);

            if (filtro.BuscarPor == BuscaEnum.Descricao && !string.IsNullOrWhiteSpace(filtro.PesquisaCampo))
            {
                query = query.Where(log => log.Descricao.Contains(filtro.PesquisaCampo));
            }

            if (filtro.BuscarPor == BuscaEnum.Level && !string.IsNullOrWhiteSpace(filtro.PesquisaCampo))
            {
                query = query.Where(log => log.TipoLog.Tipo.Contains(filtro.PesquisaCampo));
            }

            if (filtro.BuscarPor == BuscaEnum.Origem && !string.IsNullOrWhiteSpace(filtro.PesquisaCampo))
            {
                query = query.Where(log => log.Host.Contains(filtro.PesquisaCampo));
            }

            if (filtro.OrdenarPor == OrdenacaoEnum.Frequencia && !string.IsNullOrWhiteSpace(filtro.PesquisaCampo))
            {
                query = query.OrderBy(log => log.Eventos);
            }

            if (filtro.OrdenarPor == OrdenacaoEnum.Level && !string.IsNullOrWhiteSpace(filtro.PesquisaCampo))
            {
                query = query
                    .Include(log => log.TipoLog)
                    .OrderBy(log => log.TipoLog.Tipo);
            }

            return query.ToList();
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
