using ClubeApi.Infraestruture.Repository;
using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Infraestruture
{
    public interface IPessoaRepository
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