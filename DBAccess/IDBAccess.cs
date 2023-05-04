using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBAccess
{
    public interface IDBAccess
    {
        Task<string> Execute<T>(string query, T parameters);
        Task<T> Get<T, U>(string query, U parameters);
        Task<int> GetCount<U>(string query, U parameters);
        Task<List<T>> GetList<T, U>(string query, U parameters);
    }
}