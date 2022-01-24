using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.ApplicationServices
{
    public class ApplicationServiceMensalidade : IApplicationServiceMensalidade
    {
        //Atributos de referência às estrutura de serviço e mapeamento
        private readonly IServiceMensalidade service;
        private readonly IMapperMensalidade mapper;

        //Construtor
        public ApplicationServiceMensalidade(IServiceMensalidade service, IMapperMensalidade mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public void Add(MensalidadeDTO mensalidadeDTO)
        {
            Mensalidade mensalidade = mapper.MapperDTOToEntity(mensalidadeDTO);
            service.Add(mensalidade);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public IEnumerable<MensalidadeDTO> GetAll()
        {
            IEnumerable<Mensalidade> mensalidades = service.GetAll();
            return mapper.MapperListEntityToDTO(mensalidades);
        }

        public MensalidadeDTO GetById(int id)
        {
            Mensalidade mensalidade = service.GetById(id);
            return mapper.MapperEntityToDTO(mensalidade);
        }

        public void Update(int id)
        {
            service.Update(id);
        }
    }
}
