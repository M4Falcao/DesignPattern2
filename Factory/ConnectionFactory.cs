using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern2
{
    public class ConnectionFactory
    {
        public SqlConnection OpenConnection()
        {

            string connectionString = "Data Source=SEUSERVIDOR;Initial Catalog=SUA_BASE_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}