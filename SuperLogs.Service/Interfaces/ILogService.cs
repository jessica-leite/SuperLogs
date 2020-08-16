using SuperLogs.Model;
using SuperLogs.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperLogs.Service
{
    interface ILogService
    {
        void Criar(CriarLogDto log);

        Log BuscaPorId(int id);
        IList<Log> BuscaPorHostName(string hostName);

        IList<Log> BuscaPorTitulo(string titulo);

        IList<Log> BuscaPorIdStatus(int idStatus);

        IList<Log> BuscaPorIdAmbiente(int idAmbiente);
        IList<Log> BuscaPorTokenUsuario(string tokenUsuario);
        IList<Log> BuscaPorIdTipoLog(int idTipoLog);
        IList<Log> BuscaPorEventos(int eventos);
        IList<Log> BuscaPorData(DateTime data);
    }
}
