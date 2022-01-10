using ClubeApi.Domain;
using ClubeApi.Domain;
namespace ClubeApi.Infraestruture.UnityOfWork
{
    public interface ISocioUnityOfWork
    {

        ISocioRepository SocioRepository { get; }
        Task Commit();

    }
}
