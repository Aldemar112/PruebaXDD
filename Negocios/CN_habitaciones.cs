using HotelRivera_Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class CN_habitaciones
    {
        CD_habitaciones oCD_habitaciones = new CD_habitaciones();
        public DataTable BuscarHabitaciones(int TipoHabitacion)
        {
            return oCD_habitaciones.BuscarHabitaciones(TipoHabitacion);
        }
    }
}
