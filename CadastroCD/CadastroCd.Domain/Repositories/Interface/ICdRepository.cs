

using Cd.Domain.Model;

namespace Cd.Domain.Repositories.Interface
{
    public interface ICdRepository
    {
        int AddCd(CdMusica cd);
        Task<List<CdMusica>> GetAll();
        int UpdateCd(CdMusica cd);       
    }
}
