using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Transport.DTOs
{
    public class FiltroLogDto
    {
        public int IdAmbiente { get; set; }
        public OrdenacaoEnum? OrdenarPor { get; set; }
        public BuscaEnum? BuscarPor { get; set; }
        public string PesquisaCampo { get; set; }
    }

    public enum OrdenacaoEnum
    {
        Level,
        Frequencia
    }

    public enum BuscaEnum
    {
        Level,
        Descricao,
        Origem
    }
}
