using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Interfaces
{
    public interface IMensalidadeService
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Mensalidade>> GetMensalidadesAsync();

        Task<Mensalidade> GetMensalidadeAsync(int idMensalidade);

        Task PostMensalidadeAsync(Mensalidade mensalidade);

        /*
        Task PutMensalidadeAsync(int idMensalidade);

        Task DeleteMensalidadeAsync(int idMensalidade);
        */
    }
}