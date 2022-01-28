using ClubeApi.Application.DTOs;

namespace ClubeApi.Application.Interfaces.ApplicationServices
{
    public interface IApplicationServiceFuncionario
    {
        //Métodos a serem desenvolvidos para a classe DTO(segue o padrão do repositório)
        void Add(FuncionarioDTO funcionarioDTO);

        void Update(FuncionarioDTO funcionarioDTO);

        FuncionarioDTO GetById(int id);

        void Delete(FuncionarioDTO funcionarioDTO);

        int Validate(FuncionarioDTO funcionarioDTO);
    }
}
