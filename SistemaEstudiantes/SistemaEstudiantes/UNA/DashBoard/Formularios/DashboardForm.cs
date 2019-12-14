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

    public partial class DashboardForm : Form
    {
        private Usuario usuario;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            BienvenidaSistemaForm bForm = new BienvenidaSistemaForm();
              if(  bForm.ShowDialog()==DialogResult.OK){
                usuario = bForm.Usuario;

                UsuarioActualtoolStripStatusLabel.Text = usuario.Nombre;
            }
            else
            {
                this.Close();
            }
        }
    }
}
