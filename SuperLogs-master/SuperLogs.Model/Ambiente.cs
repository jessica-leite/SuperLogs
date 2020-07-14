using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperLogs.Model
{
    [Table("Ambiente")]
    public class Ambiente
    {
        [Key]
        public int IdAmbiente { get; set; }

        [Required]
        public string Tipo { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
