using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.ApplicationServices
{
    public class ApplicationServiceFuncionario : IApplicationServiceFuncionario
    {
        //Atributos de referência às estrutura de serviço e mapeamento
        private readonly IServiceFuncionario service;
        private readonly IMapperFuncionario mapper;

        //Construtor
        public ApplicationServiceFuncionario(IServiceFuncionario service, IMapperFuncionario mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public void Add(FuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = mapper.MapperDTOToEntity(funcionarioDTO);
            service.Add(funcionario);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public void Update(int id)
        {
            service.Update(id);
        }

        public int Validate(FuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = mapper.MapperDTOToEntity(funcionarioDTO);
            return service.Validate(funcionario);
        }
    }
}
