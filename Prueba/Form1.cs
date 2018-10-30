using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Prueba.WSLoad;

namespace Prueba
{

    
    public partial class Form1 : Form
    {
        WSLoad.DBSoapClient ws = new WSLoad.DBSoapClient();
        int DPIEliminar;
        int DPIModificar;
        //Datos obtenidos de datagridview
        Int64 valor1;
        string valor2;
        DateTime valor3;
        int valor4;
        DateTime valor5;
        DateTime valor6;
        float valor7;
        int valor8;
        string valor9;

        DataGridViewRow row;

        public void RegistroSeleccionado()
        {
            //por el numero obtiene la columna
            valor1 = Int64.Parse(row.Cells[0].Value.ToString());
            valor2 = row.Cells[1].Value.ToString();
            valor3 = DateTime.Parse(row.Cells[2].Value.ToString());
            valor4 = int.Parse(row.Cells[3].Value.ToString());
            string valida = row.Cells[4].Value.ToString();
            if (valida != "")
            {
                valor5 = DateTime.Parse(row.Cells[4].Value.ToString());
            }
            else
            {
                valor5 = DateTime.Now.Date;
            }
            string valida2 = row.Cells[5].Value.ToString();
            if (valida != "")
            {
                valor6 = DateTime.Parse(row.Cells[5].Value.ToString());
            }
            else
            {
                valor6 = DateTime.Now.Date;
            }

            valor7 = float.Parse(row.Cells[6].Value.ToString());
        }

        public void BuscarAfiliado() {
            if (string.IsNullOrEmpty(txt_tp0_BusquedaId.Text))
            {
                MessageBox.Show("Debe ingresar in DPI");
            }
            else
            {
                String BusqId = this.txt_tp0_BusquedaId.Text;
                DPIEliminar = int.Parse(BusqId);
                dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + BusqId + "'", null, null, "TBL_USERS");

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

        public void Boton_modificar_TP0() {
            txt_tp2_DPI.Text = valor1.ToString();
            txt_tp2_nombre.Text = valor2;
            dtp_tp2_fnacimiento.Value = valor3;
            txt_tp2_telefono.Text = valor4.ToString();
            dtp_tp2_IniCober.Value = valor5;
            dtp_tp2_FinCober.Value = valor6;
            txt_tp2_monto.Text = valor7.ToString();
            tabControl1.SelectedIndex = 2;
        }


        public void AgregarAfiliado() {

            try
            {
                Int64 AddDPI;
                String AddNombre;
                String AddApellido;
                int addTelefono;
                String addFechaNaci;
                String addTipoPoliza;
                String NomCompleto;
                float monto = 0;

                if (string.IsNullOrEmpty(txt_tp1_DPI.Text) || string.IsNullOrEmpty(txt_tp1_Nombre.Text) || string.IsNullOrEmpty(txt_tp1_Apellido.Text) || string.IsNullOrEmpty(txt_tp1_Telefono.Text) || combo_tp1_Cober.Items.Count <= 0)
                {
                    MessageBox.Show("Debe completar la informacion");
                }
                else
                {
                    AddDPI = Int64.Parse(this.txt_tp1_DPI.Text);
                    AddNombre = this.txt_tp1_Nombre.Text;
                    AddApellido = this.txt_tp1_Apellido.Text;
                    addTelefono = int.Parse(this.txt_tp1_Telefono.Text);
                    addFechaNaci = this.dtp_tp1_fechaNaci.Text;
                    addTipoPoliza = this.combo_tp1_Cober.SelectedItem.ToString();
                    NomCompleto = AddNombre + " " + AddApellido;
                    ws.ADDAfiliado(AddDPI, NomCompleto, addFechaNaci, addTelefono, monto, addTipoPoliza);
                    dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_AFILIADOS] ", null, null, "TBL_USERS");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("OPPS... XP : " + error);
            }
        }

        public Form1()
        {
            InitializeComponent();
           
            combo_tp1_Cober.Items.Add("Premium");
            combo_tp1_Cober.Items.Add("Standar");

            combo_tp2_Cober.Items.Add("Premium");
            combo_tp2_Cober.Items.Add("Standar");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarAfiliado();
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btn_agregarAfi_Click(object sender, EventArgs e)
        {
            AgregarAfiliado();

        }

        private void comCober_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_EliminarAfi_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_AFILIADOS] ", null, null, "TBL_USERS");
        }

        private void txtEliminar_TextChanged(object sender, EventArgs e)
        {
                    }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                MessageBox.Show("Debe seleccionar un registros");
                return;
            }
            else
            {
                row = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("" + row);
                RegistroSeleccionado();

                DPIEliminar = valor1;
            }
        }

        private void btn_EliminarAfi_Click_1(object sender, EventArgs e)
        {
      
            ws.DELAfiliado(DPIEliminar);
            dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_AFILIADOS] ", null, null, "TBL_USERS");
        }

        private void btn_tp0_agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Boton_modificar_TP0();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_tp1_DPI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
