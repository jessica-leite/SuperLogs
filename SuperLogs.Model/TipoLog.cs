using System.Collections.Generic;

namespace SuperLogs.Model
{
    public class TipoLog
    {
        public int IdTipoLog { get; set; }
        public string Tipo { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
