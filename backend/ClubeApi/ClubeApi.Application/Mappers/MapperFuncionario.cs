using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.Mappers;
using ClubeApi.Domain.Models;

namespace ClubeApi.Application.Mappers
{
    public class MapperFuncionario : IMapperFuncionario
    {
        public Funcionario MapperDTOToEntity(FuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = new Funcionario()
            {
                Id = funcionarioDTO.Id,
                Nome = funcionarioDTO.Nome,
                Email = funcionarioDTO.Email,
                Usuario = funcionarioDTO.Usuario,
                Senha = funcionarioDTO.Senha
            };

            return funcionario;
        }

        public FuncionarioDTO MapperEntityToDTO(Funcionario funcionario)
        {
            FuncionarioDTO funcionarioDTO = new FuncionarioDTO()
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Email = funcionario.Email,
                Usuario = funcionario.Usuario,
                Senha = funcionario.Senha
            };

            return funcionarioDTO;
        }
    }
}
