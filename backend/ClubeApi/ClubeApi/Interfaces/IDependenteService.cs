using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Interfaces
{
    public interface IDependenteService
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Dependente>> GetDependentesAsync();

        Task<Dependente> GetDependenteAsync(int idDependente);

        Task PostDependenteAsync(Dependente dependente);

        /*
        Task PutDependenteAsync(int idDependente);

        Task DeleteDependenteAsync(int idDependente);
        */
    }
}
