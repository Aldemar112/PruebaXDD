using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Presentacion;

namespace HotelRivera_Proyecto.Datos
{
    public class CD_clientes
    {
        public bool BuscarCliente(string NumDocumento)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_BuscarCliente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@NumDocumento", NumDocumento);
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            if(leer.Read())
                            {
                                GlobalClientes.NumDocumento = leer["NumDocumento"].ToString();
                                GlobalClientes.TipoDoc = (int)leer["TipoDoc"];
                                GlobalClientes.LugarExpedicion = (int)leer["LugarExpedicion"];
                                GlobalClientes.Nombres = leer["Nombres"].ToString();
                                GlobalClientes.Apellidos = leer["Apellidos"].ToString();
                                GlobalClientes.Nacionalidad = (int)leer["Nacionalidad"];
                                GlobalClientes.Profesion = leer["Profesion"].ToString();
                                GlobalClientes.Correo = leer["Correo"].ToString();
                                GlobalClientes.Telefono = leer["Telefono"].ToString();
                                GlobalClientes.FechaNacimiento = (DateTime)leer["FechaNacimiento"];
                                return true;
                            }
                            else
                            {
                                GlobalClientes.NumDocumento = "";
                                GlobalClientes.TipoDoc = 1;
                                GlobalClientes.LugarExpedicion = 0;
                                GlobalClientes.Nombres = "";
                                GlobalClientes.Apellidos = "";
                                GlobalClientes.Nacionalidad = 1;
                                GlobalClientes.Profesion = "";
                                GlobalClientes.Correo = "";
                                GlobalClientes.Telefono = "";
                                GlobalClientes.FechaNacimiento = DateTime.Now;
                                return false;
                            }                              
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Error al buscar Documento: " + ex.Message);
                        return false; ; }               
            }
        }
        public void InsertarCliente(CE_clientes oCE_clientes)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_InsertarCliente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@NumDocumento", oCE_clientes.NumDocumento);
                        comando.Parameters.AddWithValue("@TipoDoc", oCE_clientes.TipoDoc);
                        comando.Parameters.AddWithValue("@LugarExpedicion", oCE_clientes.LugarExpedicion);
                        comando.Parameters.AddWithValue("@Nombres", oCE_clientes.Nombres);
                        comando.Parameters.AddWithValue("@Apellidos", oCE_clientes.Apellidos);
                        comando.Parameters.AddWithValue("@Nacionalidad", oCE_clientes.Nacionalidad);
                        comando.Parameters.AddWithValue("@Profesion", oCE_clientes.Profesion);
                        comando.Parameters.AddWithValue("@Correo", oCE_clientes.Correo);
                        comando.Parameters.AddWithValue("@Telefono", oCE_clientes.Telefono);
                        comando.Parameters.AddWithValue("@FechaNacimiento", oCE_clientes.FechaNacimiento);                       
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al registrar el usuario: " + ex.Message); }
            }
        }
        public void EditarCliente(CE_clientes oCE_clientes)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_EditarCliente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@NumDocumento", oCE_clientes.NumDocumento);
                        comando.Parameters.AddWithValue("@TipoDoc", oCE_clientes.TipoDoc);
                        comando.Parameters.AddWithValue("@LugarExpedicion", oCE_clientes.LugarExpedicion);
                        comando.Parameters.AddWithValue("@Nombres", oCE_clientes.Nombres);
                        comando.Parameters.AddWithValue("@Apellidos", oCE_clientes.Apellidos);
                        comando.Parameters.AddWithValue("@Nacionalidad", oCE_clientes.Nacionalidad);
                        comando.Parameters.AddWithValue("@Profesion", oCE_clientes.Profesion);
                        comando.Parameters.AddWithValue("@Correo", oCE_clientes.Correo);
                        comando.Parameters.AddWithValue("@Telefono", oCE_clientes.Telefono);
                        comando.Parameters.AddWithValue("@FechaNacimiento", oCE_clientes.FechaNacimiento);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al actualizar el usuario: " + ex.Message); }
            }
        }
    }
}
