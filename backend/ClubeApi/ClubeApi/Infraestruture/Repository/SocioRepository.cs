using ClubeApi.Domain;
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

        public async Task PostSocioAsync(Socio socio)
        {
            await _socios.AddAsync(socio);
        }

       
    }
}
