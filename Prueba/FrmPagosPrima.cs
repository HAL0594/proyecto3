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
            }
            else
            {
                string BusqId = this.TxtNit.Text;
                var consulta = new DataTable(); 

                consulta = ws.LoadData("SELECT NombreCom FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + BusqId + "'", null, null, "TBL_AFILIADOS");

                

                if (consulta.Rows.Count == 0){

                    MessageBox.Show("El registro No existe");
                    return;
                }

                this.TxtNombre.Text =  consulta.Rows[0]["NombreCom"].ToString();
                    
                   
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
