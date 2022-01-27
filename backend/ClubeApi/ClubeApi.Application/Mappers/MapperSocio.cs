using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Mappers
{
    public class MapperSocio : IMapperSocio
    {
        public Socio MapperDTOToEntity(SocioDTO socioDTO)
        {
            Socio socio = new Socio()
            {
                Id = socioDTO.Id,
                Nome = socioDTO.Nome,
                Email = socioDTO.Email,
                NumeroCartao = socioDTO.NumeroCartao,
                Telefone = socioDTO.Telefone,
                Cep = socioDTO.Cep,
                Uf = socioDTO.Uf,
                Cidade = socioDTO.Cidade,
                Bairro = socioDTO.Bairro,
                Logradouro = socioDTO.Logradouro
            };

            return socio;
        }

        public SocioDTO MapperEntityToDTO(Socio socio)
        {
            SocioDTO socioDTO = new SocioDTO()
            {
                Id = socio.Id,
                Nome = socio.Nome,
                Email = socio.Email,
                NumeroCartao = socio.NumeroCartao,
                Telefone = socio.Telefone,
                Cep = socio.Cep,
                Uf = socio.Uf,
                Cidade = socio.Cidade,
                Bairro = socio.Bairro,
                Logradouro = socio.Logradouro
            };

            return socioDTO;
        }

        public IEnumerable<SocioDTO> MapperListEntityToDTO(IEnumerable<Socio> socios)
        {
            IEnumerable<SocioDTO> sociosDTO = socios.Select(s => new SocioDTO()
            {
                Id = s.Id,
                Nome = s.Nome,
                Email = s.Email,
                NumeroCartao = s.NumeroCartao,
                Telefone = s.Telefone,
                Cep = s.Cep,
                Uf = s.Uf,
                Cidade = s.Cidade,
                Bairro = s.Bairro,
                Logradouro = s.Logradouro
            });

            return sociosDTO;
        }
    }
}
