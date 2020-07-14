using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperLogs.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
