using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Transport.DTOs
{
    public class ListarLogDto
    {
        public int IdLog { get; set; }
        public string Level { get; set; }
        public string Descricao { get; set; }
        public int Eventos { get; set; }
    }
}
