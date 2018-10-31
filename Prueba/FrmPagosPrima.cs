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
    public partial class FrmPagosPrima : Form
    {

        public void BuscarAfiliado()
        {
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Debe ingresar in DPI");
            }
            else
            {
                string BusqId = this.TxtNit.Text;
                DPIEliminar = BusqId;
                dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + BusqId + "'", null, null, "TBL_AFILIADOS");

                try
                {
                    dataGridView1.Rows[0].Selected = true;
                    row = dataGridView1.Rows[0];
                    RegistroSeleccionado();
                }
                catch (Exception error)
                {
                    MessageBox.Show("El registro No existe");
                }

                DPIEliminar = valor1;
            }
        }


        public FrmPagosPrima()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAfiliado();
        }

        private void FrmPagosPrima_Load(object sender, EventArgs e)
        {

        }
    }
}
