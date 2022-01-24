using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryCategoria
    {
        //Métodos a serem desenvolvidos para esta classe
        //Método para cadastrar categoria
        void Add(Categoria obj);

        //Método para atualizar categoria
        void Update(int id);

        //Método para deletar categoria
        void Delete(int id);

        //Método para listar categorias
        IEnumerable<Categoria> GetAll();
    }
}
