using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBAccess;
using HRIS.Sample.Models;

namespace HRIS.Sample.Repository
{
    public class V_Number_TempData : IV_Number_TempData
    {
        #region Construction

        private readonly IDBAccess db;

        public V_Number_TempData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<List<V_Number_Temp>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "sam.V_Number_Temp_List @APIKey, @KeyW, @Page, @PageSize";
            return db.GetList<V_Number_Temp, dynamic>(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW }
            };

            string query = "sam.V_Number_Temp_Count @APIKey, @KeyW";
            return db.GetCount(query, param);
        }

        public Task<V_Number_Temp> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Id",ID }
            };

            string query = "sam.V_Number_Temp_Get @APIKey, @ID";
            return db.Get<V_Number_Temp, dynamic>(query, param);
        }

        public Task<string> Save(string APIKey, V_Number_Temp obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Id",obj.Id },
                { "V_Number",obj.V_Number },
                  { "In_Time",obj.In_Time },
                    { "Out_Time",obj.Out_Time },
                      { "Status",obj.Status },
                { "LogUserID",LogUserID }
            };

            string query = "sam.V_Number_Temp_AddEdit @APIKey, @Id, @V_Number,@In_Time,@Out_Time,@Status, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }

        public Task<string> Delete(string APIKey, string ID, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Id",ID },
                { "LogUserID",LogUserID }
            };

            string query = "sam.V_Number_Temp_Delete @APIKey, @Id, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }

    }
}
