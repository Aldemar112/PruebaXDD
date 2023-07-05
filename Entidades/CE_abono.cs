using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Entidades
{
    public class CE_abono
    {
        public int CodReserva { get; set; }
        public int MetodoPago { get; set; }
        public DateTime Fecha { get; set; }
        public float Valor { get; set; }
    }
}
