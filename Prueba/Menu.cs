using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresaAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAfiliado = new Form1();
            frmAfiliado.MdiParent = this;
            frmAfiliado.Show();

        }

        private void ingresoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManProvee = new MantProveedores();
            frmManProvee.MdiParent = this;
            frmManProvee.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pagoPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PagoPrima = new FrmPagosPrima();
            PagoPrima.MdiParent = this;
            PagoPrima.Show();
        }
    }
}
