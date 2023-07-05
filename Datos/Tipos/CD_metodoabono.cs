using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelRivera_Proyecto.Entidades;

namespace HotelRivera_Proyecto.Datos.Tipos
{
    public class CD_metodoabono
    {
        public DataTable BuscarMetodoAbono()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_MetodoAbonos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
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
        public void IngresarAbono(CE_abono oCE_abono)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_InsertarAbono", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@CodReserva", oCE_abono.CodReserva);
                        comando.Parameters.AddWithValue("@MetodoPago", oCE_abono.MetodoPago);
                        comando.Parameters.AddWithValue("@Fecha", oCE_abono.Fecha);
                        comando.Parameters.AddWithValue("@Valor", oCE_abono.Valor);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al registrar el usuario: " + ex.Message); }
            }
        }
    }
}
