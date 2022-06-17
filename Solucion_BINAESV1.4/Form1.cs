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
    public partial class frmPrincipal : Form
    {

        private List<Bitmap> ListaImagenes;
        public frmPrincipal()
        {
            InitializeComponent();

            ListaImagenes = new List<Bitmap>();
            ListaImagenes.Add(Resources.pic_banner_2);
            ListaImagenes.Add(Resources.pic_banner);
            ListaImagenes.Add(Resources.pic_banner_3);
            ListaImagenes.Add(Resources.pic_4_banner);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 0;
        }

        private void buscarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 1;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 2;
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 3;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 4;
        }

        private void modificarYEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 5;
        }

        private void modifcarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 7;
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 9;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabContenedor.ItemSize = new Size(0, 1);
        }

        //para mostrar los resultado del datagripview
        private void dgvBuscadorejemplar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //para eviatar errores al celeccionar en una celda no  valida
            if (e.RowIndex != -1)
            {

            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmagregarejemplar otroForm = new frmagregarejemplar())
            {
                DialogResult resultado = otroForm.ShowDialog();
            }
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (frmRegistrarevento otroForm = new frmRegistrarevento())
            {
                DialogResult resultado = otroForm.ShowDialog();
            }
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (frmAgregarusuario otroForm = new frmAgregarusuario())
            {
                DialogResult resultado = otroForm.ShowDialog();
            }
        }

        private int contadorBanner = 0;
        private void timercarrito_Tick(object sender, EventArgs e)
        {

            if (contadorBanner < ListaImagenes.Count)
            {
                pictureBox4.Image = ListaImagenes[contadorBanner];
                contadorBanner++;

                if (contadorBanner == ListaImagenes.Count)
                {
                    contadorBanner = 0;
                }
            }
        }

    }
}
