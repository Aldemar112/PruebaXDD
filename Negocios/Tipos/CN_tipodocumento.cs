using HotelRivera_Proyecto.Datos.Tipos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Tipos
{
    public class CN_tipodocumento
    {
        CD_tipodocumento oCD_tipodocumento = new CD_tipodocumento();
        public DataTable BuscarTipoDocumento()
        {
            return oCD_tipodocumento.BuscarTipoDocumento();
        }
    }
}
