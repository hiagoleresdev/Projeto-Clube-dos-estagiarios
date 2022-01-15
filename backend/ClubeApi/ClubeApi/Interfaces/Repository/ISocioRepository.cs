using ClubeApi.Domain;
using ClubeApi.Infraestruture.Repository;
using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Infraestruture
{
    public interface ISocioRepository 
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Socio>> GetSociosAsync();

        Task<Socio> GetSocioAsync(int idSocio);

        Task PostSocioAsync(Socio Socio);

        /*
        Task PutSocioAsync(int idSocio);

        Task DeleteSocioAsync(int idSocio);
        */
    }
}
