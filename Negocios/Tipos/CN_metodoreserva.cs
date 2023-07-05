using HotelRivera_Proyecto.Datos.Tipos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Tipos
{
    public class CN_metodoreserva
    {
        CD_metodoreserva oCD_metodoreserva = new CD_metodoreserva();
        public DataTable BuscarMetodoReserva()
        {
            return oCD_metodoreserva.BuscarMetodoReserva();
        }
    }
}
