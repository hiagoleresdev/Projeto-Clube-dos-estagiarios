using ClubeApi.Application.DTOs;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Interfaces.Mappers
{
    public interface IMapperSocio
    {
        //Métodos a serem desenvolvidos para esta classe para maepamento
        Socio MapperDTOToEntity(SocioDTO socioDTO);

        IEnumerable<SocioDTO> MapperListEntityToDTO(IEnumerable<Socio> socios);

        SocioDTO MapperEntityToDTO(Socio socio);
    }
}
