using HotelRivera_Proyecto.Datos.Ubicacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Ubicacion
{
    public class CN_pais
    {
        CD_pais oCD_pais = new CD_pais();      
        public DataTable BuscarPais()
        {
            return oCD_pais.BuscarPais();
        }
    }
}   
