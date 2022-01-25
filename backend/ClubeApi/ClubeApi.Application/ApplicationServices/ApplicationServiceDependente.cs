using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.ApplicationServices
{
    public class ApplicationServiceDependente : IApplicationServiceDependente
    {
        //Atributos de referência às estrutura de serviço e mapeamento
        private readonly IServiceDependente service;
        private readonly IMapperDependente mapper;

        //Construtor
        public ApplicationServiceDependente(IServiceDependente service, IMapperDependente mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public void Add(DependenteDTO dependenteDTO)
        {
            Dependente dependente = mapper.MapperDTOToEntity(dependenteDTO);
            service.Add(dependente);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public IEnumerable<DependenteDTO> GetAll()
        {
            IEnumerable<Dependente> dependentes = service.GetAll();
            return mapper.MapperListEntityToDTO(dependentes);
        }

        public DependenteDTO GetById(int id)
        {
            Dependente dependente = service.GetById(id);
            return mapper.MapperEntityToDTO(dependente);
        }

        public void Update(int id)
        {
            service.Update(id);
        }
    }
}
