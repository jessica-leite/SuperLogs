using SuperLogs.Model;
using SuperLogs.Model.Context;
using SuperLogs.Service.Interfaces;
using System;
using System.Collections.Generic;
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
        /*
        Ambiente IAmbienteService.Atualizar(int id, Ambiente ambiente)
        {
            throw new NotImplementedException();
        }

        bool IAmbienteService.Deletar(int id)
        {
            throw new NotImplementedException();
        }

        List<Ambiente> IAmbienteService.ListarTodos()
        {
            throw new NotImplementedException();
        }

        Ambiente IAmbienteService.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        Ambiente IAmbienteService.Salvar(Ambiente ambiente)
        {
            throw new NotImplementedException();
        }*/
    }
}
