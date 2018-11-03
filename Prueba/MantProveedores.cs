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
    public partial class MantProveedores : Form
    {

        WSLoad.DBSoapClient ws = new WSLoad.DBSoapClient();
        string NITEliminar;
        string NITModificar;
        //Datos obtenidos de datagridview
        string valor1;
        string valor2;
        string valor3;
        string valor4;
        string valor5;
        string valor6;
        string valor7;
        string valor8;
        string valor9;

        DataGridViewRow row;

        public void RegistroSeleccionado()
        {

            try
            {
                //por el numero obtiene la columna
                valor1 = row.Cells[0].Value.ToString();
                valor2 = row.Cells[1].Value.ToString();
                valor3 = row.Cells[2].Value.ToString();
                valor4 = row.Cells[3].Value.ToString();
                valor5 = row.Cells[4].Value.ToString();
                valor6 = row.Cells[5].Value.ToString();
                valor7 = row.Cells[6].Value.ToString();
                valor8 = row.Cells[7].Value.ToString();
                valor9 = row.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);

            }
          
        }

        public void BuscarProveedor()
        {
            if (string.IsNullOrEmpty(txt_tp0_Nit.Text))
            {
                MessageBox.Show("Debe ingresar in DPI");
            }
            else
            {
                string BusqId = this.txt_tp0_Nit.Text;
                NITEliminar = BusqId;
                dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_PROVEEDORES] WHERE NIT = '" + BusqId + "'", null, null, "TBL_PROVEEDORES");

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

                NITEliminar = valor1;
            }
        }

        public void Boton_modificarProveedor_TP0()
        {

            try
            {
                txt_Mod_NIT.Text = valor1;
                txt_Mod_nombre.Text = valor2;
                txt_Mod_direccion.Text = valor3;
                txt_Mod_telefono.Text = valor4;
                txt_Mod_correo.Text = valor7;
                txt_Mod_NomEn.Text = valor8;

                tabControl1.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
          
        }


        public void AgregarProveedor()
        {

            try
            {
                String AddNIT;
                String AddNombre;
                String AddDireccion;
                int addTelefono;
                String addPais;
                String addCiudad;
                String addCorreo;
                string addEncargado;
                int addEstado;

                if (string.IsNullOrEmpty(txt_tp1_correo.Text) || string.IsNullOrEmpty(txt_tp1_dirreccion.Text) || string.IsNullOrEmpty(txt_tp1_nit.Text) || string.IsNullOrEmpty(txt_tp1_nombre.Text) || string.IsNullOrEmpty(txt_tp1_NomEn.Text) || string.IsNullOrEmpty(txt_tp1_telefono.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                }
                else
                {
                    AddNIT = this.txt_tp1_nit.Text;
                    AddNombre = this.txt_tp1_nombre.Text;
                    AddDireccion = this.txt_tp1_dirreccion.Text;
                    addTelefono = int.Parse(txt_tp1_telefono.Text);
                    addPais = this.combo_tp1_pais.SelectedItem.ToString();
                    addCiudad = this.combo_tp1_ciudad.SelectedItem.ToString();
                    addCorreo = this.txt_tp1_correo.Text;
                    addEncargado = this.txt_tp1_NomEn.Text;
                    addEstado = int.Parse(this.combo_tp1_estado.SelectedItem.ToString());
                    ws.AddProveedor(AddNIT, AddNombre, AddDireccion, addTelefono, addPais, addCiudad, addCorreo, addEncargado, addEstado);
                    dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_PROVEEDORES] ", null, null, "TBL_PROVEEDORES");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("OPPS... XP : " + error);
            }
        }

        public void ModificarProveedor()
        {
            try
            {
                String ModNIT = this.txt_Mod_NIT.Text;
                String ModNombre = this.txt_Mod_nombre.Text;
                String ModDireccion = this.txt_Mod_direccion.Text;
                int ModTelefono = int.Parse(this.txt_Mod_telefono.Text);
                String ModPais = this.combo_Mod_pais.SelectedItem.ToString();
                String ModCiudad = this.combo_Mod_ciudad.SelectedItem.ToString();
                String ModCorreo = this.txt_Mod_correo.Text;
                string ModEncargado = this.txt_Mod_NomEn.Text;
                int ModEstado = int.Parse(this.combo_Mod_estado.SelectedItem.ToString());
                ws.ModProveedor(ModNIT, ModNombre, ModDireccion, ModTelefono, ModPais, ModCiudad, ModCorreo, ModEncargado, ModEstado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
            
        }

        public MantProveedores()
        {
            InitializeComponent();

            combo_tp1_ciudad.Items.Add("Guatemala");
            combo_tp1_ciudad.Items.Add("zacapa");

            combo_tp1_pais.Items.Add("Guatemala");
            combo_tp1_pais.Items.Add("Salvador");

            combo_tp1_estado.Items.Add("1");
            combo_tp1_estado.Items.Add("0");

            combo_Mod_pais.Items.Add("Guatemala");
            combo_Mod_pais.Items.Add("zacapa");

            combo_Mod_ciudad.Items.Add("Guatemala");
            combo_Mod_ciudad.Items.Add("Salvador");

            combo_Mod_estado.Items.Add("1");
            combo_Mod_estado.Items.Add("0");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ws.DelProveddor(NITEliminar);
            dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_PROVEEDORES] ", null, null, "TBL_PROVEEDORES");
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tp0_buscar_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void btn_tp0_nuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_tp0_modificar_Click(object sender, EventArgs e)
        {
            Boton_modificarProveedor_TP0();
        }

        private void btn_tp1_agregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                MessageBox.Show("Debe seleccionar un registros");
                return;
            }
            else
            {
                row = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Selecciono la Fila");
                RegistroSeleccionado();

                NITEliminar = valor1;
            }
        }

        private void btn_tp2_Actualiza_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
        }

        private void btn_tp0_vertodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ws.LoadData("SELECT * FROM [dbo].[TBL_PROVEEDORES] ", null, null, "TBL_PROVEEDORES");
        }
    }
}
