using HotelRivera_Proyecto.Datos.Tipos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Tipos
{
    public class CN_tipohabitacion
    {
        CD_tipohabitacion oCD_tipohabitacion = new CD_tipohabitacion();
        public DataTable BuscarTipoHabitacion()
        {
            return oCD_tipohabitacion.BuscarTipoHabitacion();
        }
    }
}
