using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AIS.Modules
{
    public class DBConnector
    {
        public void Connect()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\AIS\\AIS\\AIS\\SuperStoreDB.mdf;Integrated Security=True");
            connection.Open();
            var commannd = new SqlCommand("INSERT INTO Clients (Name) VALUES ('Sam');", connection);
            commannd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
