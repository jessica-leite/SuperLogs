using SuperLogs.Model;
using System.Collections.Generic;

namespace SuperLogs.Service.Interfaces
{
    public interface IAmbienteService
    {
        Ambiente Salvar(Ambiente ambiente);
        /*Ambiente ObterPorId(int id);
        Ambiente Atualizar(int id, Ambiente ambiente);
        bool Deletar(int id);
        List<Ambiente> ListarTodos();*/
    }
}