using System;
using System.Collections.Generic;

namespace SuperLogs.Model
{
    public class Status
    {
        public int IdStatus { get; set; }

        public String Tipo { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
