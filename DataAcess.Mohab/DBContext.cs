using Microsoft.Data.SqlClient;
using System.Data;

namespace Mohab.DataAcess
{
    
    public class DBContext
    {
        SqlConnection con;
        public DBContext(/*SqlConnection _con*/)
        {
            //Dependancy Injection
            //con = _con;
            con = new SqlConnection("Server=.\\SQLexpress;Database=MohabStore;Trusted_Connection=True;Trust Server Certificate=True");
        }

        //Disconnected => Select 
        public DataTable ExecuteQuery(string command)
        {
            SqlCommand selectCommand = new SqlCommand(command, con);

            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt; 
        }

        //Connceted => Insert, Delete, update
        public int ExecuteNonQuery(string command)
        {
            SqlCommand commandText = new SqlCommand(command, con);

            con.Open();

            int rowAffected = commandText.ExecuteNonQuery();

            con.Close();

            return rowAffected;
        }

    }
}
