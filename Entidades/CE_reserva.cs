using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Entidades
{
    public class CE_reserva
    {
        public string NumHabitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int MetodoReserva { get; set; }
        public int Estado { get; set; }
        public float Precio { get; set; }       
    }
}
