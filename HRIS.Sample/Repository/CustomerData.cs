using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBAccess;
using HRIS.Sample.Models;

namespace HRIS.Sample.Repository
{
    public class CustomerData : ICustomerData
    {
        #region Construction

        private readonly IDBAccess db;

        public CustomerData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion


        public Task<List<Customer>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "dbo.Customer_List @APIKey, @KeyW, @Page, @PageSize";
            return db.GetList<Customer, dynamic>(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW }
            };

            string query = "dbo.Customer_Count @APIKey, @KeyW";
            return db.GetCount(query, param);
        }

        public Task<Customer> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Id",ID }
            };

            string query = "dbo.Customer_Get @APIKey, @ID";
            return db.Get<Customer, dynamic>(query, param);
        }

        public Task<string> Save(string APIKey, Customer obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Cus_id",obj.Cus_id },
                { "Cus_name",obj.Cus_name },
                  { "Cus_addresss",obj.Cus_addresss },
                    { "Cus_email",obj.Cus_email },
                    { "Cus_password",obj.Cus_password },
                      { "Cus_phonenumber",obj.Cus_phonenumber },
                { "LogUserID",LogUserID }
            };

            string query = "dbo.Customer_AddEdit @APIKey, @Cus_id, @Cus_name, @Cus_addresss, @Cus_email, @Cus_password, @Cus_phonenumber, @LogUserID, @RetValue OUT";
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

            string query = "dbo.Customer_Delete @APIKey, @Id, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }

    }
}
