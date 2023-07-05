using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRivera_Proyecto.Presentacion.Registro
{
    public partial class RegistroAcompañantes : Form
    {
        string NumDocumentoTitular = string.Empty;
        public RegistroAcompañantes(string numDocumento)
        {
            InitializeComponent();
            NumDocumentoTitular = numDocumento;
        }
    }
}
