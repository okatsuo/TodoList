using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TodoList
{
    class Banco
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        string connectionString = "DATA SOURCE=.\\SQLSERVER; INITIAL CATALOG=todo; INTEGRATED SECURITY=TRUE";

        public void execMutation(string SQL)
        {
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = SQL;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public SqlCommand execQuery(string SQL)
        {
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = SQL;
            return sqlCommand;
        }

        public SqlDataReader execConsultReturn(string SQL)
        {
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = SQL;
            return sqlCommand.ExecuteReader();
        }
    }
}
