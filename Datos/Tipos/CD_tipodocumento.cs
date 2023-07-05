using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Datos.Tipos
{
    public class CD_tipodocumento
    {
        public DataTable BuscarTipoDocumento()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_TipoDocumento", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            dt.Load(leer);
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al buscar Documento: " + ex.Message); }
                return dt;
            }
        }
    }
}
