
using ClubeApi.Domain;
using ClubeApi.Common;
using ClubeApi.Infraestruture.Repository;
using ClubeApi.Infraestruture.UnityOfWork;
namespace ClubeApi.Service;



    public class SocioService : ISocioService
    {
        private ISocioUnityOfWork _unitOfWork;

        public SocioService(ISocioUnityOfWork socioUnitOfWork)
        {
            _unitOfWork = socioUnitOfWork;
        }

        public async Task<int?> PostSocioAsync(Socio socio)
        {
            ValidarSocio(socio);

            await _unitOfWork.SocioRepository.PostSocioAsync(socio);

            await _unitOfWork.Commit();

            return socio.Id;
        }

        private void ValidarSocio(Socio socio)
        {
            if (socio.Nome == null)
             throw new DomainException("Precisa ter nome");
    }
}
