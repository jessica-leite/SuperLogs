using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Transport.DTOs
{
    public class UsuarioDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
