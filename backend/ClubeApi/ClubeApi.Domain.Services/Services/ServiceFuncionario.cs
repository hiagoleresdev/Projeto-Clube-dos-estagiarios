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
            repository.Add(obj);
        }

        public void Delete(Funcionario obj)
        {
            repository.Delete(obj);
        }

        public void Update(Funcionario obj)
        {
            repository.Update(obj);
        }

        public int Validate(Funcionario obj)
        {
            return repository.Validate(obj);
        }
    }
}
