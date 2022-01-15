using ClubeApi.Domain;

namespace ClubeApi.Infraestruture.Repository
{
    public interface ISocioService
    {
        Task<int?> PostSocioAsync(Socio socio);
    }
}
