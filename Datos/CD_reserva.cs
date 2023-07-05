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
    public class CD_reserva
    {
        public void InsertarReserva(CE_reserva oCE_reserva)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_InsertarReserva", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@NumHabitacion", oCE_reserva.NumHabitacion);
                        comando.Parameters.AddWithValue("@FechaIngreso", oCE_reserva.FechaIngreso);
                        comando.Parameters.AddWithValue("@FechaSalida", oCE_reserva.FechaSalida);
                        comando.Parameters.AddWithValue("@MetodoReserva", oCE_reserva.MetodoReserva);
                        comando.Parameters.AddWithValue("@Estado", oCE_reserva.Estado);
                        comando.Parameters.AddWithValue("@Precio", oCE_reserva.Precio);
                        comando.ExecuteNonQuery();                     
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al registrar el usuario: " + ex.Message); }
            }
        }
        public int BuscarReservaMayor()
        {
            int Numero = 0;
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_buscarReservaMayor", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            if (leer.Read())
                            {
                                Numero = (int)leer["Codigo"];
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al buscar Pais: " + ex.Message); }
                return Numero;
            }
        }
    }
}
