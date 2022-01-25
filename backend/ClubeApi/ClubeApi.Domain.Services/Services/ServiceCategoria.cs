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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
