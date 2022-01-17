using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Interfaces
{
    public interface IPessoaService
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Pessoa>> GetPessoasAsync();

        Task<Pessoa> GetPessoaAsync(int idPessoa);

        Task PostPessoaAsync(Pessoa pessoa);

        /*
        Task PutPessoaAsync(int idPessoa);

        Task DeletePessoaAsync(int idPessoa);
        */
    }
}