using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Interfaces
{
    public interface ICategoriaService
    {
        //M�todos a serem desenvolvidos
        Task<IEnumerable<Categoria>> GetCategoriaAsync();
    }
}