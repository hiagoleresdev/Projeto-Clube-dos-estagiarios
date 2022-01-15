using ClubeApi.Infraestruture.Repository;
using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Infraestruture
{
    public interface ICategoriaRepository
    {
        //M�todos a serem desenvolvidos
        Task GetCategoriaAsync(Categoria categoria);
    }
}