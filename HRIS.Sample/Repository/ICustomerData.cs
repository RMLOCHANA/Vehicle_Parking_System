using HRIS.Sample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRIS.Sample.Repository
{
    public interface ICustomerData
    {
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<Customer> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "");
        Task<List<Customer>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999);
        Task<string> Save(string APIKey, Customer obj, string LogUserID);
    }
}