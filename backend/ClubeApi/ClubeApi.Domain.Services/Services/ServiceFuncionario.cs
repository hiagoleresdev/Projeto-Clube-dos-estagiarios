using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Services.Services
{
    internal class ServiceFuncionario : IServiceFuncionario
    {
        //Atributo de referência ao repositório para implementa-lo
        private readonly IRepositoryFuncionario repository;

        //Construtor
        public ServiceFuncionario(IRepositoryFuncionario repository)
        {
            this.repository = repository;
        }

        public void Add(Funcionario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public int Validate(Funcionario obj)
        {
            throw new NotImplementedException();
        }
    }
}
