using ClubeApi.Application.DTOs;

namespace ClubeApi.Application.Interfaces.ApplicationServices
{
    public interface IApplicationServiceDependente
    {
        //Métodos a serem desenvolvidos para a classe DTO(segue o padrão do repositório)
        void Add(DependenteDTO dependenteDTO);

        void Update(DependenteDTO dependenteDTO);

        void Delete(DependenteDTO dependenteDTO);

        IEnumerable<DependenteDTO> GetAll();

        DependenteDTO GetById(int id);
    }
}
