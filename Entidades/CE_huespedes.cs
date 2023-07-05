using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Entidades
{
    public class CE_huespedes
    {
        public string NumDocuTitular { get; set; }
        public int CodReserva { get; set; }
        public string NumDocuAcompañante { get; set; }
        public int CiuProcedencia { get; set; }
        public int CiuDestino { get; set; }
        public string Empresa { get; set; }     
    }
}
