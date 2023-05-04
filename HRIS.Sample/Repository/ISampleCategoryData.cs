using HRIS.Sample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRIS.Sample.Repository
{
    public interface ISampleCategoryData
    {
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<SampleCategory> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "");
        Task<List<SampleCategory>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999);
        Task<string> Save(string APIKey, SampleCategory obj, string LogUserID);
    }
}