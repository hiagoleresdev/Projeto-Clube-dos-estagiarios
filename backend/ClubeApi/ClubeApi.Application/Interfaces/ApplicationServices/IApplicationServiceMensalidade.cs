using ClubeApi.Application.DTOs;

namespace ClubeApi.Application.Interfaces.ApplicationServices
{
    public interface IApplicationServiceMensalidade
    {
        //Métodos a serem desenvolvidos para a classe DTO(segue o padrão do repositório)
        void Add(MensalidadeDTO mensalidadeDTO);

        void Update(MensalidadeDTO mensalidadeDTO);

        void Delete(MensalidadeDTO mensalidadeDTO);

        IEnumerable<MensalidadeDTO> GetAll();

        MensalidadeDTO GetById(int id);
    }
}
