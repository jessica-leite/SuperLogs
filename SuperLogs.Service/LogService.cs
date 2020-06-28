using Microsoft.EntityFrameworkCore;
using SuperLogs.Model;
using SuperLogs.Model.Context;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperLogs.Service
{
    public class LogService
    {
        private AppDbContext _context;

        public LogService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Log log)
        {
            _context.Log.Add(log);
            _context.SaveChanges();
        }
    }
}
