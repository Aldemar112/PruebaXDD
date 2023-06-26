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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        CN_usuario oCN_usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();
        bool editar = false;
        private void Admin_Load(object sender, EventArgs e)
        {
            carga();
        }
        private void carga()
        {
            DataTable dt = oCN_usuario.BuscarUsuarioAdmin();
            dgvUsuarios.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                try
                {
                    oCE_usuario.Cedula = txtCedula.Text;
                    oCE_usuario.Nombre = txtNombres.Text;
                    oCE_usuario.Correo = txtCorreo.Text;
                    oCE_usuario.Estado = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells["Estado"].Value);
                    oCN_usuario.EditarUsuario(oCE_usuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mal" + ex);
                }
                editar = false;
            }
            else
            {
                try
                {
                    oCE_usuario.Cedula = txtCedula.Text;
                    oCE_usuario.Nombre = txtNombres.Text;
                    oCE_usuario.Correo = txtCorreo.Text;
                    oCN_usuario.RegistrarUsuario(oCE_usuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mal" + ex);
                }
            }
            carga();
            txtCedula.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                editar = true;
                txtCedula.Text = dgvUsuarios.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombres.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                editar = true;
                oCE_usuario.Cedula = dgvUsuarios.CurrentRow.Cells["Cedula"].Value.ToString();
                oCE_usuario.Nombre = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                oCE_usuario.Correo = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                oCE_usuario.Estado = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells["Estado"].Value);

                if (oCE_usuario.Estado)
                {
                    oCE_usuario.Estado = false;
                }
                else
                {
                    oCE_usuario.Estado = true;
                }

                oCN_usuario.EditarUsuario(oCE_usuario);
                carga();
            }
        }
    }
}
