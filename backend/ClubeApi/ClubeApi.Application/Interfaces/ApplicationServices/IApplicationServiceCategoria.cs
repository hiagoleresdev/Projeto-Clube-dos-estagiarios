using ClubeApi.Application.DTOs;

namespace ClubeApi.Application.Interfaces.ApplicationServices
{
    public interface IApplicationServiceCategoria
    {
        //Métodos a serem desenvolvidos para a classe DTO(segue o padrão do repositório)
        void Add(CategoriaDTO categoriaDTO);

        void Update(CategoriaDTO categoriaDTO);

        CategoriaDTO GetById(int id);

        void Delete(CategoriaDTO categoriaDTO);

        IEnumerable<CategoriaDTO> GetAll();
    }
}
