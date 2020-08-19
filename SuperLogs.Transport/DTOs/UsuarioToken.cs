using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Transport.DTOs
{
    public class UsuarioToken
    {
        public bool Authenticated { get; set; }
        public DateTime Expiration { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
    }
}
