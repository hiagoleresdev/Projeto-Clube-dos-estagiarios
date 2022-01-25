using ClubeApi.Application.DTOs;

namespace ClubeApi.Application.Interfaces.ApplicationServices
{
    public interface IApplicationServiceSocio
    {
        //Métodos a serem desenvolvidos para a classe DTO(segue o padrão do repositório)
        void Add(SocioDTO socioDTO);

        void Update(int id);

        void Delete(int id);

        IEnumerable<SocioDTO> GetAll();

        SocioDTO GetById(int id);
    }
}
