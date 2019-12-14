using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiantes
{
    public partial class BienvenidaSistemaForm : Form
    {
        public BienvenidaSistemaForm()
        {
            InitializeComponent();
        }

        private void Aceptarbutton2_Click(object sender, EventArgs e)
        {
            if(UsuarioTextBox.Text.Length<1){ loginErrorProvider.SetError(UsuarioTextBox, "Digite el Usuario"); }
                               
            
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text.Length < 1) { loginErrorProvider.SetError(ContraseñaTextBox, "Digite su contraseña"); }
        }
    }
}
