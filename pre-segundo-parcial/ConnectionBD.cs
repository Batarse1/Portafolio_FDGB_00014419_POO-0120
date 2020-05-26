


using System.Data;
using Npgsql;

namespace pre_segundo_parcial
{
    public class ConnectionBD
    {
        private static string sConection = 
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=Fdfb69b0*;Database=Pre_segundo_parcial"; 
        
        public static DataTable realizarConsulta(string query) {
            NpgsqlConnection connection = new NpgsqlConnection(sConection);
            DataSet ds = new DataSet();

            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }
        
        public static void realizarAccion(string act) {
            NpgsqlConnection connection = new NpgsqlConnection(sConection);

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}