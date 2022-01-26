using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Core.Interfaces.Services;
using ClubeApi.Domain.Models;

namespace ClubeApi.Domain.Services.Services
{
    public class ServiceCategoria : IServiceCategoria
    {
        //Atributo de referência ao repositório para implementa-lo
        private readonly IRepositoryCategoria repository;

        //Construtor
        public ServiceCategoria(IRepositoryCategoria repository)
        {
            this.repository = repository;
        }

        public void Add(Categoria obj)
        {
            repository.Add(obj);
        }

        public void Delete(Categoria obj)
        {
            repository.Delete(obj);
        }

        public IEnumerable<Categoria> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(Categoria obj)
        {
            repository.Update(obj);
        }
    }
}
