using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelRivera_Proyecto.Presentacion;
using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Negocios;
using System.Windows.Forms;

namespace HotelRivera_Proyecto.Datos
{
    public class CD_usuario
    {
        public bool LoginUsuario(CE_usuario oCE_usuario)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_LoginUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Cedula", oCE_usuario.Cedula);
                        comando.Parameters.AddWithValue("@Contraseña", oCE_usuario.Contraseña);

                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            if (leer.Read())
                            {
                                Global.Cedula = leer.GetString(leer.GetOrdinal("Cedula"));
                                Global.Nombre = leer.GetString(leer.GetOrdinal("Nombre"));
                                Global.Contraseña = leer.GetString(leer.GetOrdinal("Contraseña"));
                                Global.Correo = leer.GetString(leer.GetOrdinal("Correo"));
                                Global.CodRoles = leer.GetInt32(leer.GetOrdinal("CodRoles"));
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al ingresar: " + ex.Message); }
            }
            return false;
        }
        public DataTable BuscarUsuarioAdmin()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_BuscarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            dt.Load(leer);
                        }
                    }            
                }
                catch (Exception ex) {Console.WriteLine("Error al buscar usuarios: " + ex.Message); }
                return dt;
            }          
        }
        public void RegistrarUsuario(CE_usuario oCE_usuario)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_InsertarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Cedula", oCE_usuario.Cedula);
                        comando.Parameters.AddWithValue("@Nombre", oCE_usuario.Nombre);
                        comando.Parameters.AddWithValue("@Contraseña", oCE_usuario.Contraseña);
                        comando.Parameters.AddWithValue("@Correo", oCE_usuario.Correo);
                        comando.Parameters.AddWithValue("@CodRoles", oCE_usuario.CodRoles);
                        comando.Parameters.AddWithValue("@Estado", oCE_usuario.Estado);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { Console.WriteLine("Error al registrar el usuario: " + ex.Message); }
            }
        }
        public void EditarUsuario(CE_usuario oCE_usuario)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SP_ModificarUsuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Cedula", oCE_usuario.Cedula);
                    comando.Parameters.AddWithValue("@Nombre", oCE_usuario.Nombre); ;
                    comando.Parameters.AddWithValue("@Correo", oCE_usuario.Correo);
                    comando.Parameters.AddWithValue("@Estado", oCE_usuario.Estado);
                    comando.ExecuteNonQuery();
                }
                }
                catch (Exception ex) { Console.WriteLine("Error al actualizar el usuario: " + ex.Message); }
            }
        }

        public void EditarContraseña(CE_usuario oCE_usuario)
        {
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
               try
               {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_ModificarUsuariocontraseña", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Cedula", oCE_usuario.Cedula);
                        comando.Parameters.AddWithValue("@Contraseña", oCE_usuario.Contraseña);
                        //comando.Parameters.Clear();
                        comando.ExecuteNonQuery();
                    }
               }
               catch (Exception ex) { Console.WriteLine("Error al cambiar la contraseña: " + ex.Message); }
            }
        }

        public string Traercorreo(CE_usuario oCE_usuario)
        {
            string CorreoNULL=" ";
            using (SqlConnection conexion = new SqlConnection(CD_conexion.conexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_Traercorreo", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Cedula", oCE_usuario.Cedula);
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            if (leer.Read())
                            {  
                                string Correo = leer.GetString(leer.GetOrdinal("Correo"));
                                return Correo;
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("No hay correo"); }
            }
            return CorreoNULL;

            //comando.Parameters.Clear();
            //comando.Connection = Conexion.abrirconexion();
            //comando.CommandText = "TraerProducto";
            //comando.Parameters.AddWithValue("@Cod", Producto.Codigo);
            //comando.CommandType = CommandType.StoredProcedure;
            //leer = comando.ExecuteReader();
            //if (leer.Read())
            //{
            //    int cantidad = Convert.ToInt32(leer["Valor_Unidad"]);
            //    leer.Close();
            //    return cantidad;
            //}
            //else
            //{
            //    leer.Close();
            //    return 0;
            //}
            //Conexion.Cerrarconxion();
        }



    }
}




