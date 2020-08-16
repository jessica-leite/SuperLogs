using Microsoft.EntityFrameworkCore;
using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SuperLogs.Service
{
    class StatusService : IStatusInterface
    {
        private readonly AppDbContext _context;

        public StatusService(AppDbContext context)
        {
            _context = context;
        }

        public Status Salvar(Status status)
        {
            _context.Status.Add(status);
            _context.SaveChanges();
            return status;
        }

        public Status ObterPorId(int id)
        {
            var status = _context.Status.Find(id);
            return status;
        }

        public Status Atualizar(Status status)
        {
            _context.Entry(status).State = EntityState.Modified;
            _context.SaveChanges();
            return status;
        }


        public bool Deletar(int id)
        {
            var status = _context.Status.Find(id);
            if (status == null)
            {
                return false;
            }
            _context.Status.Remove(status);
            _context.SaveChanges();
            return true;
        }

        public List<Status> ListarTodos()
        {
            return _context.Status.ToList();
        }
    }
}
