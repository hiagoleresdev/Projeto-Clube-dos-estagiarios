using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Models;

namespace ClubeApi.Infrastructure.Data.Repositories
{
    public class RepositoryCategoria : IRepositoryCategoria
    {
        //Atributo de contexto para controle do banco
        private readonly SqlDbContext context;

        //Construtor
        public RepositoryCategoria(SqlDbContext context)
        {
            this.context = context;
        }

        public void Add(Categoria obj)
        {
            try
            {
                context.Set<Categoria>().Add(obj);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                Categoria obj = context.Set<Categoria>().Find(id);
                context.Remove(obj);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Categoria> GetAll()
        {
            try
            {
                return context.Set<Categoria>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(int id)
        {
            try
            {
                Categoria obj = context.Set<Categoria>().Find(id);
                context.Update(obj);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
