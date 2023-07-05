using HotelRivera_Proyecto.Datos;
using HotelRivera_Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class CN_reserva
    {
        CD_reserva oCD_reserva = new CD_reserva();
        public void InsertarReserva(CE_reserva oCE_reserva)
        {
            oCD_reserva.InsertarReserva(oCE_reserva);
        }
        public int BuscarReservaMayor()
        {
            return oCD_reserva.BuscarReservaMayor();
        }
    }
}
