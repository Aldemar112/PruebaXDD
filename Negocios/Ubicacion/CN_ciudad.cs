using HotelRivera_Proyecto.Datos.Ubicacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Ubicacion
{
    public class CN_ciudad
    {
        CD_ciudad oCD_ciudad = new CD_ciudad();
        public DataTable BuscarCiudad(int CodDepartamento)
        {
            return oCD_ciudad.BuscarCiudad(CodDepartamento);
        }
    }
}
