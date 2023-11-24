

using Cd.Domain.Model;

namespace Cd.Domain.Service.Interface
{
    public interface ICdService
    {
        int AddCd(CdMusica cd);
        Task<List<CdMusica>> GetAll();
        int UpdateCd(CdMusica cd);
    }
}
