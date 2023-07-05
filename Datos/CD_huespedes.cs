using HotelRivera_Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Datos
{
    public class CD_huespedes
    {
        public void InsertarHuespedes(CE_huespedes oCE_huespedes)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                //try
                //{
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_InsertarHuespedes", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@NumDocuTitular", oCE_huespedes.NumDocuTitular);
                        comando.Parameters.AddWithValue("@CodReserva", oCE_huespedes.CodReserva);
                        comando.Parameters.AddWithValue("@NumDocuAcompañante", oCE_huespedes.NumDocuAcompañante);
                        comando.Parameters.AddWithValue("@CiuProcedencia", oCE_huespedes.CiuProcedencia);
                        comando.Parameters.AddWithValue("@CiuDestino", oCE_huespedes.CiuDestino);
                        comando.Parameters.AddWithValue("@Empresa", oCE_huespedes.Empresa);
                        comando.ExecuteNonQuery();
                    }
                //}
                //catch (Exception ex) { Console.WriteLine("Error al registrar el usuario: " + ex.Message); }
            }
        }
    }
}
