using ClubeApi.Infraestruture.Repository;
using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Infraestruture
{
    public interface IFuncionarioRepository
    {
        //M�todos a serem desenvolvidos
        Task GetFuncionarioAsync(Funcionario funcionario);

        Task PostFuncionarioAsync(Funcionario funcionario);

        Task PutFuncionarioAsync(Funcionario funcionario);

        Task DeleteFuncionarioAsync(Funcionario funcionario);
    }
}