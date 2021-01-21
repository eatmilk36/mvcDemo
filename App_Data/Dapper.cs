using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

public class dapperHelper
{
    private string sqlConn = string.Empty;
    public SqlConnection db = null;
    public dapperHelper()
    {
        sqlConn = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        db = new SqlConnection(sqlConn);
    }

    public IEnumerable<T> Query<T>(string sql)
    {
        var list = db.Query<T>(sql);
        return null;
    }
}