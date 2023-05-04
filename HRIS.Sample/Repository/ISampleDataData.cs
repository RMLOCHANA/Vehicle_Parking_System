using HRIS.Sample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRIS.Sample.Repository
{
    public interface ISampleDataData
    {
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<SampleData> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "", string CategoryID = "", string ActiveStatus = "");
        Task<List<SampleData>> GetList(string APIKey, string KeyW = "", string CategoryID = "", string ActiveStatus = "", int Page = 0, int PageSize = 99999);
        Task<string> Save(string APIKey, SampleData obj, string LogUserID);
    }
}