using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data; 

namespace DAL
{
    public class SQLDBHelper
    {
        public readonly string connectionString = "Data Source=localhost;Initial Catalog=Youtube;Integrated Security=True";

        public void GuardarBusqueda(string informacion) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Busquedas (Informacion) VALUES (@informacion)"; 
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@informacion", SqlDbType.NVarChar).Value = informacion;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
