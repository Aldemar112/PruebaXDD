using HotelRivera_Proyecto.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Entidades
{
    public class CE_clientes
    {
        public string NumDocumento { get; set; }
        public int TipoDoc { get; set; }
        public int LugarExpedicion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Nacionalidad { get; set; }
        public string Profesion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
