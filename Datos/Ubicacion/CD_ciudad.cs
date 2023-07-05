using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Datos.Ubicacion
{
    public class CD_ciudad
    {
        public DataTable BuscarCiudad(int CodDepartamento)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_BuscarCiudad", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@CodDepartamento", CodDepartamento);
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
