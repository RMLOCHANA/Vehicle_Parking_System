using HRIS.Account.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRIS.Account.Repository
{
    public interface IUserData
    {
        Task<string> Delete(string APIKey, string ID, string LogUserID);
        Task<User> Get(string APIKey, string ID);
        Task<int> GetCount(string APIKey, string KeyW = "");
        Task<List<User>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999);
        Task<User> Login(string APIKey, string Username);
        Task<string> Save(string APIKey, User obj, string LogUserID);
    }
}