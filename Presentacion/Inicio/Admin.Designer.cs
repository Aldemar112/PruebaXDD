namespace HotelRivera_Proyecto.Presentacion.Inicio
{
    partial class Admin
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
            btnEstado = new Button();
            btnEditar = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtNombres = new TextBox();
            txtCedula = new TextBox();
            dgvUsuarios = new DataGridView();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(821, 221);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(125, 34);
            btnEstado.TabIndex = 21;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(538, 221);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 34);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(592, 70);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 19;
            label4.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(340, 70);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 18;
            label2.Text = "Nombres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 70);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 17;
            label1.Text = "Cedula";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(592, 134);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(339, 33);
            txtCorreo.TabIndex = 16;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(340, 134);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(218, 33);
            txtNombres.TabIndex = 15;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.Location = new Point(209, 134);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 33);
            txtCedula.TabIndex = 14;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 293);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(1183, 365);
            dgvUsuarios.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(294, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 34);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 670);
            Controls.Add(btnEstado);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombres);
            Controls.Add(txtCedula);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEstado;
        private Button btnEditar;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtNombres;
        private TextBox txtCedula;
        private DataGridView dgvUsuarios;
        private Button btnGuardar;
    }
}