using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Interfaces
{
    public interface IFuncionarioService
    {
        //M�todos a serem desenvolvidos
        Task GetFuncionarioAsync(Funcionario funcionario);

        Task PostFuncionarioAsync(Funcionario funcionario);

        Task PutFuncionarioAsync(Funcionario funcionario);

        Task DeleteFuncionarioAsync(Funcionario funcionario);
    }
}