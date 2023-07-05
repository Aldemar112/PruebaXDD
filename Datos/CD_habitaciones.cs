using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Datos
{
    public class CD_habitaciones
    {
        public DataTable BuscarHabitaciones(int TipoHabitacion)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_BuscarHabitaciones", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            dt.Load(leer);
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al buscar Pais: " + ex.Message); }
                return dt;
            }
        }
    }
}
