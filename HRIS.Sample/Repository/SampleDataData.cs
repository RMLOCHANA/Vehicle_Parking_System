using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBAccess;
using HRIS.Sample.Models;

namespace HRIS.Sample.Repository
{
    public class SampleDataData : ISampleDataData
    {
        #region Construction

        private readonly IDBAccess db;

        public SampleDataData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<List<SampleData>> GetList(string APIKey, string KeyW = "", string CategoryID = "", string ActiveStatus = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "CategoryID",CategoryID },
                { "ActiveStatus",ActiveStatus },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "sam.Data_List @APIKey, @KeyW, @CategoryID, @ActiveStatus, @Page, @PageSize";
            return db.GetList<SampleData, dynamic>(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "", string CategoryID = "", string ActiveStatus = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "CategoryID",CategoryID },
                { "ActiveStatus",ActiveStatus }
            };

            string query = "sam.Data_Count @APIKey, @KeyW, @CategoryID, @ActiveStatus";
            return db.GetCount(query, param);
        }

        public Task<SampleData> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "sam.Data_Get @APIKey, @ID";
            return db.Get<SampleData, dynamic>(query, param);
        }

        public Task<string> Save(string APIKey, SampleData obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "DataID",obj.DataID },
                { "CategoryID",obj.CategoryID },
                { "DataName",obj.DataName },
                { "JoinedDate",obj.JoinedDate },
                { "DataCost",obj.DataCost },
                { "DataDescription",obj.DataDescription },
                { "ActiveStatus",obj.ActiveStatus },
                { "LogUserID",LogUserID }
            };

            string query = "sam.Data_AddEdit @APIKey, @DataID, @CategoryID, @DataName, @JoinedDate, @DataCost, @DataDescription, @ActiveStatus, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }

        public Task<string> Delete(string APIKey, string ID, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID },
                { "LogUserID",LogUserID }
            };

            string query = "sam.Data_Delete @APIKey, @ID, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }
    }
}
