using HRIS.Sample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRIS.Sample.Repository
{
    public interface IV_Number_TempData
    {
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<V_Number_Temp> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "");
        Task<List<V_Number_Temp>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999);
        Task<string> Save(string APIKey, V_Number_Temp obj, string LogUserID);
    }
}