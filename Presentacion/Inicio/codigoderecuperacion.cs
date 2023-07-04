using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRivera_Proyecto.Presentacion.Inicio
{
    public partial class codigoderecuperacion : Form
    {
        public codigoderecuperacion()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            if (Global.Codigo == Txtcodigo.Text)
            {
                Cambiodecotraseña Contraseña = new Cambiodecotraseña();
                Contraseña.Show();
            }
            else
            {
                MessageBox.Show("Codigo incorrecto");
            }
        }
    }
}
