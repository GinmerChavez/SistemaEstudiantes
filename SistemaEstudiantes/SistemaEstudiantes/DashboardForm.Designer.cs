namespace SistemaEstudiantes
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.PrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrincipalStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SalirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tiempoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EstudianteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.baseDatosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsuarioActualtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMenuStrip.SuspendLayout();
            this.PrincipalToolStrip.SuspendLayout();
            this.PrincipalStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalMenuStrip
            // 
            this.PrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.verToolStripMenuItem});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.PrincipalMenuStrip.TabIndex = 1;
            this.PrincipalMenuStrip.Text = "PrincipalMenuStrip";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // PrincipalToolStrip
            // 
            this.PrincipalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirtoolStripButton,
            this.tiempoToolStripButton,
            this.checkToolStripButton,
            this.EstudianteToolStripButton,
            this.baseDatosToolStripButton});
            this.PrincipalToolStrip.Location = new System.Drawing.Point(0, 24);
            this.PrincipalToolStrip.Name = "PrincipalToolStrip";
            this.PrincipalToolStrip.Size = new System.Drawing.Size(800, 25);
            this.PrincipalToolStrip.TabIndex = 2;
            this.PrincipalToolStrip.Text = "PrincipalToolStrip";
            // 
            // PrincipalStatusStrip
            // 
            this.PrincipalStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioActualtoolStripStatusLabel});
            this.PrincipalStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.PrincipalStatusStrip.Name = "PrincipalStatusStrip";
            this.PrincipalStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.PrincipalStatusStrip.TabIndex = 3;
            this.PrincipalStatusStrip.Text = "PrincipalStatusStrip";
            // 
            // SalirtoolStripButton
            // 
            this.SalirtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SalirtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirtoolStripButton.Image")));
            this.SalirtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirtoolStripButton.Name = "SalirtoolStripButton";
            this.SalirtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SalirtoolStripButton.Text = "Salir";
            // 
            // tiempoToolStripButton
            // 
            this.tiempoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tiempoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tiempoToolStripButton.Image")));
            this.tiempoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiempoToolStripButton.Name = "tiempoToolStripButton";
            this.tiempoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.tiempoToolStripButton.Text = "Hora";
            this.tiempoToolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // checkToolStripButton
            // 
            this.checkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.checkToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkToolStripButton.Image")));
            this.checkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkToolStripButton.Name = "checkToolStripButton";
            this.checkToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.checkToolStripButton.Text = "Confirmar";
            // 
            // EstudianteToolStripButton
            // 
            this.EstudianteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EstudianteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EstudianteToolStripButton.Image")));
            this.EstudianteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EstudianteToolStripButton.Name = "EstudianteToolStripButton";
            this.EstudianteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EstudianteToolStripButton.Text = "Estudiante";
            // 
            // baseDatosToolStripButton
            // 
            this.baseDatosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baseDatosToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("baseDatosToolStripButton.Image")));
            this.baseDatosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baseDatosToolStripButton.Name = "baseDatosToolStripButton";
            this.baseDatosToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.baseDatosToolStripButton.Text = "Datos";
            // 
            // UsuarioActualtoolStripStatusLabel
            // 
            this.UsuarioActualtoolStripStatusLabel.Name = "UsuarioActualtoolStripStatusLabel";
            this.UsuarioActualtoolStripStatusLabel.Size = new System.Drawing.Size(197, 17);
            this.UsuarioActualtoolStripStatusLabel.Text = "Usuario actual: @UsuarioAtenticado";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrincipalStatusStrip);
            this.Controls.Add(this.PrincipalToolStrip);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PrincipalMenuStrip;
            this.Name = "DashboardForm";
            this.Text = "Sistema de Control Estudiantil";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.PrincipalMenuStrip.ResumeLayout(false);
            this.PrincipalMenuStrip.PerformLayout();
            this.PrincipalToolStrip.ResumeLayout(false);
            this.PrincipalToolStrip.PerformLayout();
            this.PrincipalStatusStrip.ResumeLayout(false);
            this.PrincipalStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip PrincipalToolStrip;
        private System.Windows.Forms.ToolStripButton SalirtoolStripButton;
        private System.Windows.Forms.ToolStripButton tiempoToolStripButton;
        private System.Windows.Forms.StatusStrip PrincipalStatusStrip;
        private System.Windows.Forms.ToolStripButton checkToolStripButton;
        private System.Windows.Forms.ToolStripButton EstudianteToolStripButton;
        private System.Windows.Forms.ToolStripButton baseDatosToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioActualtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}