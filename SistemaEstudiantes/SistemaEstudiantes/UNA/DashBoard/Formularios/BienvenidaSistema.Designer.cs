namespace SistemaEstudiantes
{
    partial class BienvenidaSistemaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Usuariolabel1 = new System.Windows.Forms.Label();
            this.Contraseñalabel2 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.Aceptarbutton2 = new System.Windows.Forms.Button();
            this.OlvidoContraseñalinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariolabel1
            // 
            this.Usuariolabel1.AutoSize = true;
            this.Usuariolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Usuariolabel1.Location = new System.Drawing.Point(37, 53);
            this.Usuariolabel1.Name = "Usuariolabel1";
            this.Usuariolabel1.Size = new System.Drawing.Size(61, 17);
            this.Usuariolabel1.TabIndex = 0;
            this.Usuariolabel1.Text = "Usuario:";
            // 
            // Contraseñalabel2
            // 
            this.Contraseñalabel2.AutoSize = true;
            this.Contraseñalabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Contraseñalabel2.Location = new System.Drawing.Point(37, 100);
            this.Contraseñalabel2.Name = "Contraseñalabel2";
            this.Contraseñalabel2.Size = new System.Drawing.Size(85, 17);
            this.Contraseñalabel2.TabIndex = 1;
            this.Contraseñalabel2.Text = "Contraseña:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(158, 53);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(353, 20);
            this.UsuarioTextBox.TabIndex = 2;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(158, 100);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(353, 20);
            this.ContraseñaTextBox.TabIndex = 3;
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CancelarButton.Location = new System.Drawing.Point(40, 179);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(89, 37);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // Aceptarbutton2
            // 
            this.Aceptarbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Aceptarbutton2.Location = new System.Drawing.Point(422, 179);
            this.Aceptarbutton2.Name = "Aceptarbutton2";
            this.Aceptarbutton2.Size = new System.Drawing.Size(89, 37);
            this.Aceptarbutton2.TabIndex = 5;
            this.Aceptarbutton2.Text = "Aceptar";
            this.Aceptarbutton2.UseVisualStyleBackColor = true;
            this.Aceptarbutton2.Click += new System.EventHandler(this.Aceptarbutton2_Click);
            // 
            // OlvidoContraseñalinkLabel1
            // 
            this.OlvidoContraseñalinkLabel1.AutoSize = true;
            this.OlvidoContraseñalinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OlvidoContraseñalinkLabel1.Location = new System.Drawing.Point(353, 145);
            this.OlvidoContraseñalinkLabel1.Name = "OlvidoContraseñalinkLabel1";
            this.OlvidoContraseñalinkLabel1.Size = new System.Drawing.Size(158, 17);
            this.OlvidoContraseñalinkLabel1.TabIndex = 6;
            this.OlvidoContraseñalinkLabel1.TabStop = true;
            this.OlvidoContraseñalinkLabel1.Text = "¿Olvidó su contraseña?";
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // BienvenidaSistemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(551, 235);
            this.Controls.Add(this.OlvidoContraseñalinkLabel1);
            this.Controls.Add(this.Aceptarbutton2);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.Contraseñalabel2);
            this.Controls.Add(this.Usuariolabel1);
            this.Name = "BienvenidaSistemaForm";
            this.Text = "Bienvenido al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuariolabel1;
        private System.Windows.Forms.Label Contraseñalabel2;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button Aceptarbutton2;
        private System.Windows.Forms.LinkLabel OlvidoContraseñalinkLabel1;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
    }
}

