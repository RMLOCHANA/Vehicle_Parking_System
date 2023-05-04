using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

public static class Exten
{
    public static string ExecuteOutputParam(this IDbConnection conn, string sql, object args)
    {
        var p = new DynamicParameters();

        var properties = (Dictionary<string, object>)args;
        foreach (var prop in properties)
        {
            p.Add(prop.Key, prop.Value == null ? "" : prop.Value);
        }

        p.Add("RetValue", "", DbType.String, ParameterDirection.Output, 50);

        conn.Execute(sql, p);

        string id = p.Get<string>("RetValue");
        return id;
    }

    public static async Task<string> ExecuteOutputParamAsync(this IDbConnection conn, string sql, object args)
    {
        var p = new DynamicParameters();

        var properties = (Dictionary<string, object>)args;
        foreach (var prop in properties)
        {
            p.Add(prop.Key, prop.Value == null ? "" : prop.Value);
        }

        p.Add("RetValue", "", DbType.String, ParameterDirection.Output, 50);

        await conn.ExecuteAsync(sql, p);

        string id = p.Get<string>("RetValue");
        return id;
    }
}
