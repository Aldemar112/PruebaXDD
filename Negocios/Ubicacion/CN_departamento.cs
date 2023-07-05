using HotelRivera_Proyecto.Datos.Ubicacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios.Ubicacion
{
    public class CN_departamento
    {
        CD_departamento oCD_departamento = new CD_departamento();
        public DataTable BuscarDepartamento(int CodPais)
        {
            return oCD_departamento.BuscarDepartamento(CodPais);
        }
    }
}
