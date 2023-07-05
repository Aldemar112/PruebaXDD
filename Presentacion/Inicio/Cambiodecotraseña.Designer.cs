namespace HotelRivera_Proyecto.Presentacion.Inicio
{
    partial class Cambiodecotraseña
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
            TxtContraseñaNueva = new TextBox();
            TxtcontraseñaSegunda = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TxtContraseñaNueva
            // 
            TxtContraseñaNueva.Location = new Point(65, 81);
            TxtContraseñaNueva.Name = "TxtContraseñaNueva";
            TxtContraseñaNueva.Size = new Size(100, 23);
            TxtContraseñaNueva.TabIndex = 0;
            // 
            // TxtcontraseñaSegunda
            // 
            TxtcontraseñaSegunda.Location = new Point(69, 163);
            TxtcontraseñaSegunda.Name = "TxtcontraseñaSegunda";
            TxtcontraseñaSegunda.Size = new Size(100, 23);
            TxtcontraseñaSegunda.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 34);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Contraseña nueva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 130);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 4;
            label2.Text = "Confirmar contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(59, 209);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 5;
            button1.Text = "Cambiar contrseña";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cambiodecotraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 292);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtcontraseñaSegunda);
            Controls.Add(TxtContraseñaNueva);
            Name = "Cambiodecotraseña";
            Text = "Cambiodecotraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtcontraseñaSegunda;
        private Label label1;
        private Label label2;
        private Button button1;
        static private TextBox TxtContraseñaNueva;
    }
}