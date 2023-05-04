using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWeb;
using MainWeb.Models;

// Helps to get application related data

public class AppData
{
    public static string GetMSSQLDBCon()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Data source=");sb.Append(SettingHelper.AppSetting("DBSettings:Server"));
        sb.Append(";Initial Catalog=");sb.Append(SettingHelper.AppSetting("DBSettings:Database"));
        sb.Append(";User Id=");sb.Append(SettingHelper.AppSetting("DBSettings:UserId"));
        sb.Append(";Password=");sb.Append(SettingHelper.AppSetting("DBSettings:Password"));

        return sb.ToString();
    }

    public static string GetAPIKey()
    {
        return "1032";
    }

    public static string GetEncryptionKey()
    {
        //return "b14ca5898a4e4133bbce2ea2315a1916";
        return "c14aa5898b4a4133bbce2ea2315a1916";
    }

    public static List<int> GetPaginationList(int RecordCount, int PageSize)
    {
        var retList = new List<int>();

        if (RecordCount > PageSize)
        {
            int PageCount = RecordCount / PageSize;
            if (RecordCount % PageSize > 0)
            {
                PageCount += 1;
            }

            for (int i = 1; i <= PageCount; i++)
            {
                retList.Add(i);
            }
        }

        return retList;
    }
    
}