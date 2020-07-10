using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace SuperLogs.Model
{
    [Table("TipoLog")]
    public class TipoLog
    {
        [Key]
        public int IdTipoLog { get; set; }

        [Required]
        public string Tipo { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
