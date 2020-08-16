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
        public string TokenUsuario { get; set; }


        [Required, Column("IdStatus"), ForeignKey("Status")]
        public int IdStatus { get; set; }
        public Status Status { get; set; }

        [Required,Column("IdAmbiente"), ForeignKey("Ambiente")]
        public int IdAmbiente { get; set; }
        public Ambiente Ambiente { get; set; }

        [Required,Column("IdTipoLog"), ForeignKey("TipoLog")]
        public int IdTipoLog { get; set; }
        public TipoLog TipoLog { get; set; }

    }
}
