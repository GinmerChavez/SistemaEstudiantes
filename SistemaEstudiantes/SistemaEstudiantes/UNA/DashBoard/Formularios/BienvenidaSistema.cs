using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.DashBoard.Objetos;

namespace SistemaEstudiantes
{
    public partial class BienvenidaSistemaForm : Form
    {
        public BienvenidaSistemaForm()
        {
            InitializeComponent();
        }

        public Usuario Usuario { get; set; }

        private void Aceptarbutton2_Click(object sender, EventArgs e)
        {
            if (ValidarInformacion())
            {

                DialogResult = DialogResult.OK;

                Usuario = new Usuario()
                {
                    Nombre = UsuarioTextBox.Text,
                    Contraseña = ContraseñaTextBox.Text

                };

                this.Close();
            }

        }

        private bool ValidarInformacion()
        {
            bool esValida = true;

            if (UsuarioTextBox.Text.Length < 1) { loginErrorProvider.SetError(UsuarioTextBox, "Digite el Usuario"); esValida = false; }
            if (ContraseñaTextBox.Text.Length < 1) { loginErrorProvider.SetError(ContraseñaTextBox, "Digite su contraseña"); esValida = false; }

            return esValida;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
