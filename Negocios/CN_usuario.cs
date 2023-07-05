using HotelRivera_Proyecto.Datos;
using HotelRivera_Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class CN_usuario
    {

        CD_usuario oCD_usuario = new CD_usuario();
        public bool LoginUsuario(CE_usuario oCE_usuario)
        {
            return oCD_usuario.LoginUsuario(oCE_usuario);
        }
        public DataTable BuscarUsuarioAdmin()
        {
            return oCD_usuario.BuscarUsuarioAdmin();
        }
        public void RegistrarUsuario(CE_usuario oCE_usuario)
        {
            oCE_usuario.CodRoles = 2;
            oCE_usuario.Estado = true;
            oCE_usuario.Contraseña = "admin";
            oCD_usuario.RegistrarUsuario(oCE_usuario);
        }
        public void EditarUsuario(CE_usuario oCE_usuario)
        {
            oCD_usuario.EditarUsuario(oCE_usuario);
        }
    }
}


