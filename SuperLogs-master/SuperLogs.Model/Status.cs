using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace SuperLogs.Model
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int IdStatus { get; set; }

        [Required]
        public String Tipo { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
