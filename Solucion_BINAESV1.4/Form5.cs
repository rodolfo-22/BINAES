using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_BINAES
{
    public partial class frmRegistrarevento : Form
    {
        public frmRegistrarevento()
        {
            InitializeComponent();
        }

        private void btnCancelarregistroevento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
