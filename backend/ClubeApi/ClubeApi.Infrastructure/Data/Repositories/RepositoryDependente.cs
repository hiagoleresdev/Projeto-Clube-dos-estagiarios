using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Models;

namespace ClubeApi.Infrastructure.Data.Repositories
{
    public class RepositoryDependente : RepositoryBase<Dependente>, IRepositoryDependente
    {
        //Atributo de contexto para controle do banco
        private readonly SqlDbContext context;

        //Construtor
        public RepositoryDependente(SqlDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
