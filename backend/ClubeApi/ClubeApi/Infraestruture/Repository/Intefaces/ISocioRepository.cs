using ClubeApi.Domain;
using ClubeApi.Infraestruture.Repository;
using Microsoft.EntityFrameworkCore;
using ClubeApi.Domain;

namespace ClubeApi.Infraestruture
{
    public interface ISocioRepository {

       
        Task PostSocioAsync(Socio socio);
        


    }
}
