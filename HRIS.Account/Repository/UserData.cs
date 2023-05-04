using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBAccess;
using HRIS.Account.Models;

namespace HRIS.Account.Repository
{
    public class UserData : IUserData
    {
        #region Construction

        private readonly IDBAccess db;

        public UserData(IDBAccess db)
        {
            this.db = db;
        }

        #endregion

        public Task<List<User>> GetList(string APIKey, string KeyW = "", int Page = 0, int PageSize = 99999)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW },
                { "Page",Page },
                { "PageSize",PageSize }
            };

            string query = "syst.User_List @APIKey, @KeyW, @Page, @PageSize";
            return db.GetList<User, dynamic>(query, param);
        }

        public Task<int> GetCount(string APIKey, string KeyW = "")
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "KeyW",KeyW }
            };

            string query = "syst.User_Count @APIKey, @KeyW";
            return db.GetCount(query, param);
        }

        public Task<User> Get(string APIKey, string ID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "ID",ID }
            };

            string query = "syst.User_Get @APIKey, @ID";
            return db.Get<User, dynamic>(query, param);
        }

        public Task<User> Login(string APIKey, string Username)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "Username",Username }
            };

            string query = "syst.User_Login @APIKey, @Username";
            return db.Get<User, dynamic>(query, param);
        }

        public Task<string> Save(string APIKey, User obj, string LogUserID)
        {
            var param = new Dictionary<string, object>
            {
                { "APIKey",APIKey },
                { "UserID",obj.UserID },
                { "UserName",obj.Username },
                { "Password",obj.Password },
                { "DisplayName",obj.DisplayName },
                { "RoleMode",obj.RoleMode },
                { "ActiveStatus",obj.ActiveStatus },
                { "LogUserID",LogUserID }
            };

            string query = "syst.User_AddEdit @APIKey, @UserID, @UserName, @Password, @DisplayName, @RoleMode, @ActiveStatus, @LogUserID, @RetValue OUT";
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

            string query = "syst.User_Delete @APIKey, @ID, @LogUserID, @RetValue OUT";
            return db.Execute(query, param);
        }
    }
}
