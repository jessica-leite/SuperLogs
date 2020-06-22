using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperLogs.Model
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int IdLog { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Eventos { get; set; }

        [Required]
        public string Host { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int IdStatus { get; set; }

        [Required]
        public int IdAmbiente { get; set; }

        [Required]
        public int IdTipoLog { get; set; }

        [Required]
        public int IdUsuario { get; set; }
    }
}
