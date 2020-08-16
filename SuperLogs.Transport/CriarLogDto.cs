using System;
using System.ComponentModel.DataAnnotations;

namespace SuperLogs.Transport
{
    public class CriarLogDto
    {
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
        public string TokenUsuario { get; set; }
    }
}
