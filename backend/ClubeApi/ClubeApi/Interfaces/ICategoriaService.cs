using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Interfaces
{
    public interface ICategoriaService
    {
        //Métodos a serem desenvolvidos
        Task<IEnumerable<Categoria>> GetCategoriaAsync();
    }
}