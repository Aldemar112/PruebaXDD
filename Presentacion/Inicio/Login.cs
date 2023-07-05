using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Negocios;
using HotelRivera_Proyecto.Presentacion.Inicio;

namespace HotelRivera_Proyecto
{
    public partial class Login : Form
    {
        CN_usuario oCN_Usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            oCE_usuario.Cedula = txtCedula.Text;
            oCE_usuario.Contraseña = txtContraseña.Text;
            if (oCN_Usuario.LoginUsuario(oCE_usuario))
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}