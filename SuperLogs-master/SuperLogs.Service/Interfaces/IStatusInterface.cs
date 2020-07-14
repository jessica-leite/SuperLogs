using SuperLogs.Model;
using System.Collections.Generic;

namespace SuperLogs.Service.Interfaces
{
    public interface IStatusInterface 
    {
        Status Salvar(Status status);
        Status ObterPorId(int id);
        Status Atualizar(Status status);
        bool Deletar(int id);
        List<Status> ListarTodos();
    }
}
