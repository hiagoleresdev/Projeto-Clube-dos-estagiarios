using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Core.Interfaces.Services
{
    public interface IServiceCategoria
    {
        //Métodos a serem desenvolvidos para esta classe(segue o padrão do repositório)
        void Add(Categoria obj);

        void Update(int id);

        void Delete(int id);

        IEnumerable<Categoria> GetAll();
    }
}
