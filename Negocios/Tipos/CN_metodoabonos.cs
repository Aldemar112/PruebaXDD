using HotelRivera_Proyecto.Datos.Tipos;
using HotelRivera_Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Tipos
{
    public class CN_metodoabonos
    {
        CD_metodoabono oCD_metodoabono = new CD_metodoabono();
        public DataTable BuscarMetodoAbono()
        {
            return oCD_metodoabono.BuscarMetodoAbono();
        }
        public void IngresarAbono(CE_abono oCE_abono)
        {
            oCD_metodoabono.IngresarAbono(oCE_abono);
        }
    }
}
