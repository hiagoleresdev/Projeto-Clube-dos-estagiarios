using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Interfaces
{
    public interface ISocioService
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Socio>> GetSociosAsync();

        Task<Socio> GetSocioAsync(int idSocio);

        Task PostSocioAsync(Socio socio);

        /*
        Task PutSocioAsync(int idSocio);

        Task DeleteSocioAsync(int idSocio);
        */
    }
}
