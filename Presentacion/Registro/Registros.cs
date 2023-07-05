
using HotelRivera_Proyecto.Entidades;
using HotelRivera_Proyecto.Negocios;
using HotelRivera_Proyecto.Negocios.Tipos;
using HotelRivera_Proyecto.Negocios.Ubicacion;
using HotelRivera_Proyecto.Presentacion.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelRivera_Proyecto.Presentacion
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        #region //Instancias de los objetos a usar

        bool guardado = true;
        int CodReserva = 0;

        DataTable dtHabitaciones = new DataTable();
        DataTable dtClientes = new DataTable();

        CN_pais oCN_pais = new CN_pais();
        CN_departamento oCN_departamento = new CN_departamento();
        CN_ciudad oCN_ciudad = new CN_ciudad();
        CN_tipodocumento oCN_tipodocumento = new CN_tipodocumento();
        CN_tipohabitacion oCN_tipohabitacion = new CN_tipohabitacion();
        CN_habitaciones oCN_habitaciones = new CN_habitaciones();
        CN_metodoabonos oCN_metodoabonos = new CN_metodoabonos();
        CN_metodoreserva oCN_metodoreserva = new CN_metodoreserva();
        CN_clientes oCN_clientes = new CN_clientes();
        CN_reserva oCN_reserva = new CN_reserva();
        CN_huespedes oCN_huespedes = new CN_huespedes();

        CE_clientes oCE_clientes = new CE_clientes();
        CE_reserva oCE_reserva = new CE_reserva();
        CE_huespedes oCE_huespedes = new CE_huespedes();
        CE_abono oCE_abono = new CE_abono();
        #endregion
        private void Registros_Load(object sender, EventArgs e)
        {
            Cargar();
            ValidacionFecha();
            dtpIngreso.MinDate = DateTime.Now.AddDays(-1);
            checkAA.AutoCheck = false;
            CodReserva = oCN_reserva.BuscarReservaMayor();
        }
        private void Cargar()
        {
            //Cargo cada combobox que hay en Registro
            cmbNacionalidad.DataSource = oCN_pais.BuscarPais();
            cmbNacionalidad.ValueMember = "Codigo";
            cmbNacionalidad.DisplayMember = "Nombre";

            cmbPaisProcedencia.DataSource = oCN_pais.BuscarPais();
            cmbPaisProcedencia.ValueMember = "Codigo";
            cmbPaisProcedencia.DisplayMember = "Nombre";

            cmbPaisDestino.DataSource = oCN_pais.BuscarPais();
            cmbPaisDestino.ValueMember = "Codigo";
            cmbPaisDestino.DisplayMember = "Nombre";

            cmbTipoDocumento.DataSource = oCN_tipodocumento.BuscarTipoDocumento();
            cmbTipoDocumento.ValueMember = "Codigo";
            cmbTipoDocumento.DisplayMember = "Nombre";

            cmbTipoHabitacion.DataSource = oCN_tipohabitacion.BuscarTipoHabitacion();
            cmbTipoHabitacion.ValueMember = "Codigo";
            cmbTipoHabitacion.DisplayMember = "Nombre";

            cmbMetodoAbono.DataSource = oCN_metodoabonos.BuscarMetodoAbono();
            cmbMetodoAbono.ValueMember = "Codigo";
            cmbMetodoAbono.DisplayMember = "Nombre";

            cmbMetoReserva.DataSource = oCN_metodoreserva.BuscarMetodoReserva();
            cmbMetoReserva.ValueMember = "Codigo";
            cmbMetoReserva.DisplayMember = "Nombre";
        }
        
        #region Metodos para cargar combobox anidados de los combobox principales
        private void CargarDepartamentoExp(int CodPais)
        {
            cmbDeparExpedicion.DataSource = oCN_departamento.BuscarDepartamento(CodPais);
            cmbDeparExpedicion.ValueMember = "Codigo";
            cmbDeparExpedicion.DisplayMember = "Nombre";
        }
        private void CargarDepartamentoProcedencia(int CodPais)
        {
            cmbDeparProcedencia.DataSource = oCN_departamento.BuscarDepartamento(CodPais);
            cmbDeparProcedencia.ValueMember = "Codigo";
            cmbDeparProcedencia.DisplayMember = "Nombre";
        }
        private void CargarDepartamentoDestino(int CodPais)
        {
            cmbDeparDestino.DataSource = oCN_departamento.BuscarDepartamento(CodPais);
            cmbDeparDestino.ValueMember = "Codigo";
            cmbDeparDestino.DisplayMember = "Nombre";
        }
        private void CargarCiudadExp(int CodDepartamento)
        {
            cmbCiuExpedicion.DataSource = oCN_ciudad.BuscarCiudad(CodDepartamento);
            cmbCiuExpedicion.ValueMember = "Codigo";
            cmbCiuExpedicion.DisplayMember = "Nombre";
        }
        private void CargarCiudadProcedencia(int CodDepartamento)
        {
            cmbCiuProcedencia.DataSource = oCN_ciudad.BuscarCiudad(CodDepartamento);
            cmbCiuProcedencia.ValueMember = "Codigo";
            cmbCiuProcedencia.DisplayMember = "Nombre";
        }
        private void CargarCiudadDestino(int CodDepartamento)
        {
            cmbCiuDestino.DataSource = oCN_ciudad.BuscarCiudad(CodDepartamento);
            cmbCiuDestino.ValueMember = "Codigo";
            cmbCiuDestino.DisplayMember = "Nombre";
        }
        private void CargarHabitaciones(int TipoHabitacion)
        {
            dtHabitaciones = oCN_habitaciones.BuscarHabitaciones(TipoHabitacion);
            cmbNumHabitacion.DataSource = dtHabitaciones;
            cmbNumHabitacion.ValueMember = "NumHabitacion";
            cmbNumHabitacion.DisplayMember = "NumHabitacion";
        }
        #endregion

        #region  se usa el evento indexchanged de cada combobox para cargar los combobox anidados
        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNacionalidad.SelectedItem != null)
            {
                if (int.TryParse(cmbNacionalidad.SelectedValue.ToString(), out int CodPais))
                {
                    CargarDepartamentoExp(CodPais);
                }
            }
        }
        private void cmbPaisProcedencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaisProcedencia.SelectedItem != null)
            {
                if (int.TryParse(cmbPaisProcedencia.SelectedValue.ToString(), out int CodPais))
                {
                    CargarDepartamentoProcedencia(CodPais);
                }
            }
        }
        private void cmbPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaisDestino.SelectedItem != null)
            {
                if (int.TryParse(cmbPaisDestino.SelectedValue.ToString(), out int CodPais))
                {
                    CargarDepartamentoDestino(CodPais);
                }
            }
        }
        private void cmbDeparExpedicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparExpedicion.SelectedItem != null)
            {
                if (int.TryParse(cmbDeparExpedicion.SelectedValue.ToString(), out int CodDepartamento))
                {
                    CargarCiudadExp(CodDepartamento);
                }
            }
        }
        private void cmbDeparProcedencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparProcedencia.SelectedItem != null)
            {
                if (int.TryParse(cmbDeparProcedencia.SelectedValue.ToString(), out int CodDepartamento))
                {
                    CargarCiudadProcedencia(CodDepartamento);
                }
            }
        }
        private void cmbDeparDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparDestino.SelectedItem != null)
            {
                if (int.TryParse(cmbDeparDestino.SelectedValue.ToString(), out int CodDepartamento))
                {
                    CargarCiudadDestino(CodDepartamento);
                }
            }
        }

        private void cmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoHabitacion.SelectedItem != null)
            {
                if (int.TryParse(cmbTipoHabitacion.SelectedValue.ToString(), out int TipoHabitacion))
                {
                    CargarHabitaciones(TipoHabitacion);
                }
            }
        }
        private void cmbNumHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //de la tabla guardada anteriormente cada vez que se selecciono una habitacion se modificaran los datos que lo integran
            int fila = Convert.ToInt32(cmbNumHabitacion.SelectedIndex.ToString());
            if (Convert.ToBoolean(dtHabitaciones.Rows[fila]["AireAcondicionado"].ToString()))
            {
                checkAA.CheckState = CheckState.Checked;
            }
            else
            {
                checkAA.CheckState = CheckState.Unchecked;
            }
            txtValorHabitacion.Text = dtHabitaciones.Rows[fila]["Valor"].ToString();
        }

        #endregion

        #region Metodo para usar en el click
        private void IngresarCliente()
        {
            //Registrar o editar el cliente
            oCE_clientes.NumDocumento = txtNumDocumento.Text;
            oCE_clientes.TipoDoc = (int)cmbTipoDocumento.SelectedValue;
            oCE_clientes.LugarExpedicion = (int)cmbCiuExpedicion.SelectedValue;
            oCE_clientes.Nombres = txtNombres.Text;
            oCE_clientes.Apellidos = txtApellidos.Text;
            oCE_clientes.Nacionalidad = (int)cmbNacionalidad.SelectedValue; ;
            oCE_clientes.Profesion = txtProfesion.Text;
            oCE_clientes.Correo = txtCorreo.Text;
            oCE_clientes.Telefono = txtTelefono.Text;
            oCE_clientes.FechaNacimiento = (DateTime)dtpFechaNacimiento.Value;

            if (guardado)
            {
                oCN_clientes.EditarCliente(oCE_clientes);
                MessageBox.Show("Bien Edito");
            }
            else
            {
                oCN_clientes.InsertarCliente(oCE_clientes);
                MessageBox.Show("Bien inserto");
                guardado = true;
            }//asigno todo los campos a sus propiedades correspondientes
            //Valido si el usuario existe, si existe lo modifico y si no lo registro
        }
        private void IngresarReserva()
        {
            //Crear la reserva
            oCE_reserva.NumHabitacion = cmbNumHabitacion.SelectedValue.ToString();
            oCE_reserva.FechaIngreso = dtpIngreso.Value;
            oCE_reserva.FechaSalida = dtpSalida.Value;
            oCE_reserva.MetodoReserva = (int)cmbMetoReserva.SelectedValue;
            oCE_reserva.Estado = 1;
            oCE_reserva.Precio = float.Parse(txtValorHabitacion.Text);
            oCN_reserva.InsertarReserva(oCE_reserva);
        }
        private void IngresarHuespedes()
        {
            //Crear huespedes
            oCE_huespedes.NumDocuTitular = txtNumDocumento.Text;
            oCE_huespedes.CodReserva = CodReserva;
            oCE_huespedes.NumDocuAcompañante = txtNumDocumento.Text;
            oCE_huespedes.CiuProcedencia = (int)cmbCiuProcedencia.SelectedValue;
            oCE_huespedes.CiuDestino = (int)cmbCiuDestino.SelectedValue;
            oCE_huespedes.Empresa = txtEmpresa.Text;
            oCN_huespedes.InsertarHuespedes(oCE_huespedes);
        }
        private void IngresarAbono()
        {
            //Si la persona quiere ingresar un abono al tener lleno el textbox lo va ingresar si no, no
            if (txtValorAbono.Text != string.Empty)
            {
                oCE_abono.CodReserva = CodReserva;
                oCE_abono.MetodoPago = (int)cmbMetodoAbono.SelectedValue;
                oCE_abono.Fecha = DateTime.Now;
                oCE_abono.Valor = Convert.ToInt32(txtValorAbono.Text);
                oCN_metodoabonos.IngresarAbono(oCE_abono);
            }
        }
        private void limpiar()
        {
            cmbTipoDocumento.SelectedIndex = 0;
            cmbNacionalidad.SelectedIndex = 0;
            cmbPaisDestino.SelectedIndex = 0;
            cmbPaisProcedencia.SelectedIndex = 0;
            cmbCiuDestino.SelectedIndex = 0;
            cmbCiuProcedencia.SelectedIndex = 0;
            cmbMetoReserva.SelectedIndex = 0;
            cmbTipoHabitacion.SelectedIndex = 0;
            cmbNumHabitacion.SelectedIndex = 0;
            cmbMetodoAbono.SelectedIndex = 0;

            dtpFechaNacimiento.Value = DateTime.Now;
            dtpIngreso.Value = DateTime.Now;

            txtNumDocumento.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtProfesion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtValorAbono.Text = string.Empty;
        }
        #endregion
        
        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            IngresarCliente();          
            IngresarReserva();
            IngresarHuespedes();
            IngresarAbono();

            DialogResult dialogResult = MessageBox.Show("Vienen Acompañantes?", "Registro Huespedes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RegistroAcompañantes FormAcompañante = new RegistroAcompañantes(txtNumDocumento.Text);
                limpiar();
                FormAcompañante.ShowDialog();
            }
            else{ limpiar(); }
        }
        //Con este metodo hago la consulta de los clientes automaticamente usando variables globales y asignandola en sus campos
        //si el usuario es encontrado la variable guardado cambiara a true sino sera false
        //esto con el proposito de crear un metodo para ingresar o editar el usuario con solo un click
        private void txtNumDocumento_TextChanged(object sender, EventArgs e)
        {
            GlobalClientes.NumDocumento = txtNumDocumento.Text;

            if (oCN_clientes.BuscarCliente(GlobalClientes.NumDocumento))
            {
                guardado = true;
            }
            else { guardado = false; }

            cmbTipoDocumento.SelectedValue = GlobalClientes.TipoDoc;
            cmbCiuExpedicion.SelectedValue = GlobalClientes.LugarExpedicion;
            txtNombres.Text = GlobalClientes.Nombres;
            txtApellidos.Text = GlobalClientes.Apellidos;
            cmbNacionalidad.SelectedValue = GlobalClientes.Nacionalidad;
            txtProfesion.Text = GlobalClientes.Profesion;
            txtCorreo.Text = GlobalClientes.Correo;
            txtTelefono.Text = GlobalClientes.Telefono;
            dtpFechaNacimiento.Value = GlobalClientes.FechaNacimiento;
        }      

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //Metodo de validacion para las fechas, la fecha de dtpSalida no puede tener fecha anterior a dtpIngreso
        private void dtpIngreso_ValueChanged(object sender, EventArgs e)
        {
            ValidacionFecha();
        }
        private void ValidacionFecha()
        {
            //asigno que la fecha minima y valor va ser un dia mas que el de dtpingreso
            dtpSalida.MinDate = dtpIngreso.Value.AddDays(1);
            dtpSalida.Value = dtpIngreso.Value.AddDays(1);
        }
    }
}
