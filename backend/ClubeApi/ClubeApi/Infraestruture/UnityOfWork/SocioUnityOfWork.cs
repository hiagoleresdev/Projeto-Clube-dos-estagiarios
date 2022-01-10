using ClubeApi.Domain;
using ClubeApi.Infraestruture.UnityOfWork;

namespace ClubeApi.Infraestruture.UnityOfWork
{
    public class SocioUnityOfWork: ISocioUnityOfWork
    {
        private ClubeDbContext _dbContext;

        public ISocioRepository SocioRepository { get; }

        public SocioUnityOfWork(ISocioRepository pessoaRepository,ClubeDbContext coxaDbContext)
        {
             SocioRepository = pessoaRepository;
            _dbContext = coxaDbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
