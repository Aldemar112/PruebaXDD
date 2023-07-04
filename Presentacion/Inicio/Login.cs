using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Negocios;
using HotelRivera_Proyecto.Presentacion;
using HotelRivera_Proyecto.Presentacion.Inicio;
using System.Data.SqlClient;

namespace HotelRivera_Proyecto
{
    public partial class Login : Form
    {
        CN_usuario oCN_Usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();
        Correo Correo=new Correo();
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            oCE_usuario.Cedula = txtCedula.Text;
            oCE_usuario.Contraseña =Encriptacion.Encrip(txtContraseña.Text);
            if (oCN_Usuario.LoginUsuario(oCE_usuario))
            {
                Menu menu = new Menu();
                menu.Show();
                Global.Cedula=txtCedula.Text;
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void Btnenviarcodigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedula.Text))
            {
                codigoderecuperacion codigo= new codigoderecuperacion();
                oCE_usuario.Cedula = txtCedula.Text;
                Global.Cedula = txtCedula.Text;
                oCN_Usuario.Traercoreo(oCE_usuario);
                Correo.Enviarcorreo();
                MessageBox.Show("Te enviamos un codigo al correo");
                codigo.Show();
            }
            else
            {
                MessageBox.Show("Ingrese la cedula para recuperar la contraseña");
            }
        }
    }
}