using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FN.Store.Data.ADO
{
    public class FNStoreDataContextADO : IDisposable
    {
        private readonly SqlConnection _conn;
        public FNStoreDataContextADO()
        {
            var connString = ConfigurationManager.ConnectionStrings["StoreConn"].ConnectionString;
            _conn = new SqlConnection(connString);
            _conn.Open();
        }

        public void ExecuteCommand(string sql)
        {
            var command = new SqlCommand() {
                CommandText = sql,
                CommandType = System.Data.CommandType.Text,
                Connection = _conn
            };
            command.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteCommandWithData(string query)
        {
            var command = new SqlCommand(query, _conn);
            return command.ExecuteReader();
        }


        public void Dispose()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }
    }
}
