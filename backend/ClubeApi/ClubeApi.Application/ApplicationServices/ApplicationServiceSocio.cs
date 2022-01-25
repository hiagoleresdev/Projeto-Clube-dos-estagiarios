using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.ApplicationServices
{
    public class ApplicationServiceSocio : IApplicationServiceSocio
    {
        //Atributos de referência às estrutura de serviço e mapeamento
        private readonly IServiceSocio service;
        private readonly IMapperSocio mapper;

        //Construtor
        public ApplicationServiceSocio(IServiceSocio service, IMapperSocio mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public void Add(SocioDTO socioDTO)
        {
            Socio socio = mapper.MapperDTOToEntity(socioDTO);
            service.Add(socio);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public IEnumerable<SocioDTO> GetAll()
        {
            IEnumerable<Socio> socios = service.GetAll();
            return mapper.MapperListEntityToDTO(socios);
        }

        public SocioDTO GetById(int id)
        {
            Socio socio = service.GetById(id);
            return mapper.MapperEntityToDTO(socio);
        }

        public void Update(int id)
        {
            service.Update(id);
        }
    }
}
