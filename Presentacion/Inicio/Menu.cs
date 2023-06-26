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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            switch (Global.CodRoles)
            {
                case 1:
                    btnAjustes.Visible = true; break;
                case 2:
                    btnAjustes.Visible = false; break;
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Abrir(new Admin());
        }
        private void Abrir(Form formulario)
        {
            this.pnContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(formulario);
            this.pnContenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Abrir(new Reserva());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Abrir(new Registros());
        }
    }
}
