using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Models;

namespace ClubeApi.Infrastructure.Data.Repositories
{
    public class RepositorySocio : RepositoryBase<Socio>, IRepositorySocio
    {
        //Atributo de contexto para controle do banco
        private readonly SqlDbContext context;

        //Construtor
        public RepositorySocio(SqlDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
