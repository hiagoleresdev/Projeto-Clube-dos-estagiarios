using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Core.Interfaces.Services
{
    public interface IServiceFuncionario
    {
        //Métodos a serem desenvolvidos para esta classe(segue o padrão do repositório)
        void Add(Funcionario obj);

        void Update(int id);

        void Delete(int id);

        int Validate(Funcionario obj);
    }
}
