namespace HotelRivera_Proyecto.Presentacion.Inicio
{
    partial class codigoderecuperacion
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
            Txtcodigo = new TextBox();
            Btnaceptar = new Button();
            SuspendLayout();
            // 
            // Txtcodigo
            // 
            Txtcodigo.Location = new Point(85, 89);
            Txtcodigo.Name = "Txtcodigo";
            Txtcodigo.Size = new Size(154, 23);
            Txtcodigo.TabIndex = 0;
            // 
            // Btnaceptar
            // 
            Btnaceptar.Location = new Point(125, 142);
            Btnaceptar.Name = "Btnaceptar";
            Btnaceptar.Size = new Size(75, 23);
            Btnaceptar.TabIndex = 1;
            Btnaceptar.Text = "Aceptar";
            Btnaceptar.UseVisualStyleBackColor = true;
            Btnaceptar.Click += Btnaceptar_Click;
            // 
            // codigoderecuperacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 251);
            Controls.Add(Btnaceptar);
            Controls.Add(Txtcodigo);
            Name = "codigoderecuperacion";
            Text = "codigoderecuperacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txtcodigo;
        private Button Btnaceptar;
    }
}