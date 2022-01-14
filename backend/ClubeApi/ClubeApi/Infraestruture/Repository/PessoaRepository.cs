using System.Data.Entity;
using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Infraestruture.Repository.Intefaces
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbSet<Pessoa> _pessoas;

        public PessoaRepository(ClubeDbContext clubeDbContext)
        {
            _pessoas = clubeDbContext.Pessoas;
        }

        //M�todo de listagem de pessoas
        public async Task<IEnumerable<Pessoa>> GetPessoasAsync()
        {
            return await _pessoas.ToListAsync();
        }

        //M�todo de busca por ID
        public async Task<Pessoa> GetPessoaAsync(int idPessoa)
        {
            return await _pessoas.FindAsync(idPessoa);
        }
        
        //M�todo para cadastrar pessoa
        public async Task PostPessoaAsync(Pessoa Pessoa)
        {
            await _pessoas.AddAsync(Pessoa);
        }
        
        ////M�todo para atualizar pessoa
        //public async Task PutPessoaAsync(int idPessoa)
        //{
        //    Pessoa pessoa = await _pessoas.FindAsync(idPessoa);
        //    _pessoas.Update(pessoa);
        //    await _pessoas.SaveChangesAsync();
        //}
        
        ////M�todo para deletar pessoa
        //public async Task DeletePessoaAsync(int idPessoa)
        //{
        //    Pessoa pessoa = await _pessoas.FindAsync(idPessoa);
        //    _pessoas.Remove(pessoa);
        //    await _pessoas.SaveChangesAsync();
        //}
    }
}
