namespace HotelRivera_Proyecto.Presentacion.Inicio
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFacturas = new Button();
            pnContenedor = new Panel();
            btnInformes = new Button();
            btnHabitaciones = new Button();
            btnRegistro = new Button();
            btnReservas = new Button();
            btnAjustes = new Button();
            btnModiContraseña = new Button();
            SuspendLayout();
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(5, 593);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(132, 124);
            btnFacturas.TabIndex = 13;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            // 
            // pnContenedor
            // 
            pnContenedor.Location = new Point(143, 59);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(1207, 670);
            pnContenedor.TabIndex = 12;
            // 
            // btnInformes
            // 
            btnInformes.Location = new Point(5, 463);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(132, 124);
            btnInformes.TabIndex = 11;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.Location = new Point(5, 333);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(132, 124);
            btnHabitaciones.TabIndex = 10;
            btnHabitaciones.Text = "Habitaciones";
            btnHabitaciones.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(5, 203);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(132, 124);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnReservas
            // 
            btnReservas.Location = new Point(5, 73);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(132, 124);
            btnReservas.TabIndex = 8;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnAjustes
            // 
            btnAjustes.Location = new Point(1102, 12);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(115, 41);
            btnAjustes.TabIndex = 7;
            btnAjustes.Text = "Ajustes de admin";
            btnAjustes.UseVisualStyleBackColor = true;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // btnModiContraseña
            // 
            btnModiContraseña.Location = new Point(1223, 12);
            btnModiContraseña.Name = "btnModiContraseña";
            btnModiContraseña.Size = new Size(115, 41);
            btnModiContraseña.TabIndex = 14;
            btnModiContraseña.Text = "Modificar Contraseña";
            btnModiContraseña.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(btnModiContraseña);
            Controls.Add(btnFacturas);
            Controls.Add(pnContenedor);
            Controls.Add(btnInformes);
            Controls.Add(btnHabitaciones);
            Controls.Add(btnRegistro);
            Controls.Add(btnReservas);
            Controls.Add(btnAjustes);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnFacturas;
        private Panel pnContenedor;
        private Button btnInformes;
        private Button btnHabitaciones;
        private Button btnRegistro;
        private Button btnReservas;
        private Button btnAjustes;
        private Button btnModiContraseña;
    }
}