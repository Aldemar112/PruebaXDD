using HotelRivera_Proyecto.Datos;
using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Negocios;
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
    public partial class Cambiodecotraseña : Form
    {
        public Cambiodecotraseña()
        {
            InitializeComponent();
        }

        CD_usuario oC_Usuario = new CD_usuario();
        CN_usuario cN_Usuario = new CN_usuario();
        CE_usuario cE_Usuario = new CE_usuario();
        string Cedula = Global.Cedula;
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtContraseñaNueva.Text == TxtcontraseñaSegunda.Text)
            {
                cE_Usuario.Cedula = Cedula;
                cE_Usuario.Contraseña =Encriptacion.Encrip(TxtContraseñaNueva.Text);
                cN_Usuario.Editarcontraseña(cE_Usuario);
                MessageBox.Show("Las contraseña se cambio correctamente");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }
    }
}
