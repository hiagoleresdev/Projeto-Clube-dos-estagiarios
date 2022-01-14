using System.Data.Entity;
using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Infraestruture.Repository.Intefaces
{
    public class SocioRepository: ISocioRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbSet<Socio> _socios;

        public SocioRepository(ClubeDbContext clubeDbContext)
        {
            _socios = clubeDbContext.Socios;
        }

        //Método de listagem de sócios
        public async Task<IEnumerable<Socio>> GetSociosAsync()
        {
            return await _socios.ToListAsync();
        }

        //Método de busca por ID
        public async Task<Socio> GetSocioAsync(int idSocio)
        {
            return await _socios.FindAsync(idSocio);
        }
        
        //Método para cadastrar Socio
        public async Task PostSocioAsync(Socio Socio)
        {
            await _socios.AddAsync(Socio);
        }
        
        /*
        //Método para atualizar Socio
        public async Task PutSocioAsync(int idSocio)
        {
            Socio socio = await _socios.FindAsync(idSocio);
            _socios.Update(socio);
            await _socios.SaveChangesAsync();
        }
        
        //Método para deletar Socio
        public async Task DeleteSocioAsync(int idSocio)
        {
            Socio socio = await _socios.FindAsync(idSocio);
            _socios.Remove(socio);
            await _socios.SaveChangesAsync();
        }
        */
    }
}
