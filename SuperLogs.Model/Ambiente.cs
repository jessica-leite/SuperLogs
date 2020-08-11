using System.Collections.Generic;

namespace SuperLogs.Model
{
    public class Ambiente
    {
        public int IdAmbiente { get; set; }
        public string Tipo { get; set; }
        public ICollection<Log> Logs { get; set; }
    }
}