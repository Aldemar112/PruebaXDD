using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Entidades
{
    public class CE_usuario
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public int CodRoles { get; set; }
        public bool Estado { get; set; }

    }
}
