using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryFuncionario
    {
        //Métodos a serem desenvolvidos para esta classe
        //Método para cadastrar funcionário
        void Add(Funcionario obj);

        //Método para atualizar funcionário
        void Update(int id);

        //Método para deletar funcionário
        void Delete(int id);

        //Método para validar usuário do funcionário
        int Validate(Funcionario obj);
    }
}
