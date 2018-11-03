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

        WSLoad.DBSoapClient ws = new WSLoad.DBSoapClient();


        public void BuscarAfiliado()
        {
            if (string.IsNullOrEmpty(TxtNit.Text))
            {
                MessageBox.Show("Debe ingresar in DPI");
                return;
            }
            else
            {
                string BusqId = this.TxtNit.Text;
                
                DataTable filtros = new DataTable();

                filtros = ws.LoadData("SELECT *, codigo, nombre, persona FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + BusqId + "'", null, null, "TBL_AFILIADOS");

                if (filtros.Rows.Count == 0)

                {
                    MessageBox.Show("El registro No existe");
                    return;
                    //error de llenado de busqueda
                
                }
                //               


                filtros.Rows[0]["columna"]

                
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
