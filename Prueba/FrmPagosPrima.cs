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

                consulta = ws.LoadData("SELECT NombreCom, FechaNac, Telefono, InicioCob, FinCobertura, MontoCob  FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + BusqId + "'", null, null, "TBL_AFILIADOS");

                

                if (consulta.Rows.Count == 0){

                    MessageBox.Show("El registro No existe");
                    return;
                }

                this.lbnombre.Text =  consulta.Rows[0]["NombreCom"].ToString();
                this.lbfechaNac.Text = consulta.Rows[0]["FechaNac"].ToString();
                this.lbTelefono.Text = consulta.Rows[0]["Telefono"].ToString();
                this.lbInicioCob.Text = consulta.Rows[0]["InicioCob"].ToString();
                this.lbFinCobertura.Text = consulta.Rows[0]["FinCobertura"].ToString();
                this.txtmontoP.Text = consulta.Rows[0]["MontoCob"].ToString();

                return;   
            }
        }


        public void Agregarpago()
        {

            
            ws.AddTran(this.TxtNit,this.txtmontoP,this.lbFinCobertura);
            MessageBox.Show("Pago efectuado");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregarpago();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
