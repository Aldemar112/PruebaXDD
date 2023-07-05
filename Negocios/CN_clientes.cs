using HotelRivera_Proyecto.Datos;
using HotelRivera_Proyecto.Datos.Ubicacion;
using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class CN_clientes
    {
        CD_clientes oCD_cliente = new CD_clientes();
        public bool BuscarCliente(string NumDocumento)
        {
            return oCD_cliente.BuscarCliente(NumDocumento);
        }
        public void InsertarCliente(CE_clientes oCE_clientes)
        {
            oCD_cliente.InsertarCliente(oCE_clientes);
        }
        public void EditarCliente(CE_clientes oCE_clientes)
        {
            oCD_cliente.EditarCliente(oCE_clientes);
        }
    }
}
