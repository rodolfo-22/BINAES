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
    public partial class frmAgregarusuario : Form
    {
        public frmAgregarusuario()
        {
            InitializeComponent();
        }

        private void btncancelarusuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
