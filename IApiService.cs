using System.Collections.Generic;
using System.Threading.Tasks;

namespace api
{
    public interface IApiService
    {
        Task<IList<string>> GetValues();
    }
}