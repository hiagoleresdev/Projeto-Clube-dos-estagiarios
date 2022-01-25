using ClubeApi.Domain.Core.Interfaces.Repositories;
using ClubeApi.Domain.Models;

namespace ClubeApi.Infrastructure.Data.Repositories
{
    public class RepositoryMensalidade : RepositoryBase<Mensalidade>, IRepositoryMensalidade
    {
        //Atributo de contexto para controle do banco
        private readonly SqlDbContext context;

        //Construtor
        public RepositoryMensalidade(SqlDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
