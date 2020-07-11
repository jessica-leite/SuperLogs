using Microsoft.EntityFrameworkCore;
using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperLogs.Service
{
    public class AmbienteService : IAmbienteService
    {
        private readonly AppDbContext _context;

        public AmbienteService(AppDbContext context)
        {
            _context = context;
        }

        public Ambiente Salvar(Ambiente ambiente)
        {
            _context.Ambiente.Add(ambiente);
            _context.SaveChanges();
            return ambiente;
        }

        public Ambiente ObterPorId(int id)
        {
            var ambiente = _context.Ambiente.Find(id);
            return ambiente;
        }

        public Ambiente Atualizar(Ambiente ambiente)
        {
            _context.Entry(ambiente).State = EntityState.Modified;
            _context.SaveChanges();
            return ambiente;
        }

        
        public bool Deletar(int id)
        {
            var ambiente = _context.Ambiente.Find(id);
            if (ambiente == null)
            {
                return false;
            }
            _context.Ambiente.Remove(ambiente);
            _context.SaveChanges();
            return true;
        }
        
        public List<Ambiente> ListarTodos()
        {
            return _context.Ambiente.ToList();
        }
       
    }
}
