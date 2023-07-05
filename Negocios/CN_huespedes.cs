using HotelRivera_Proyecto.Datos;
using HotelRivera_Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class CN_huespedes
    {
        CD_huespedes oCD_huespedes = new CD_huespedes();
        public void InsertarHuespedes(CE_huespedes oCE_huespedes)
        {
            oCD_huespedes.InsertarHuespedes(oCE_huespedes);
        }
    }
}
