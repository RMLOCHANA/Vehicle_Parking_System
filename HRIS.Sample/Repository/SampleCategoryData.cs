using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBAccess;
using HRIS.Sample.Models;

namespace HRIS.Sample.Repository
{
    public class SampleCategoryData : ISampleCategoryData
    {
        #region Construction

        private readonly IDBAccess db;

        public SampleCategoryData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<List<SampleCategory>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "sam.Category_List @APIKey, @KeyW, @Page, @PageSize";
            return db.GetList<SampleCategory, dynamic>(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW }
            };

            string query = "sam.Category_Count @APIKey, @KeyW";
            return db.GetCount(query, param);
        }

        public Task<SampleCategory> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "sam.Category_Get @APIKey, @ID";
            return db.Get<SampleCategory, dynamic>(query, param);
        }

        public Task<string> Save(string APIKey, SampleCategory obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "CategoryID",obj.CategoryID },
                { "CategoryName",obj.CategoryName },
                { "LogUserID",LogUserID }
            };

            string query = "sam.Category_AddEdit @APIKey, @CategoryID, @CategoryName, @LogUserID, @RetValue OUT";
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

            string query = "sam.Category_Delete @APIKey, @ID, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }

    }
}
