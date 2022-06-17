using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solucion_BINAES.Properties;

namespace Solucion_BINAES
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarusuario_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseñausuario.Text;
            Admin Adm = AdminDAO.Existe(usuario, contraseña);

            if (Adm.usuario.Length> 0)
            {
                MessageBox.Show("Bienvenido!", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin ventana = new frmLogin(Adm);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales erróneas!", "BINAES",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
