namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_tp0_modificar = new System.Windows.Forms.Button();
            this.btn_tp0_agregar = new System.Windows.Forms.Button();
            this.btn_tp0_EliminarAfi = new System.Windows.Forms.Button();
            this.btn_tp0_buscar = new System.Windows.Forms.Button();
            this.btn_tp0_BuscarAfi = new System.Windows.Forms.Button();
            this.txt_tp0_BusquedaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_tp1_Telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tp1_agregarAfi = new System.Windows.Forms.Button();
            this.combo_tp1_Cober = new System.Windows.Forms.ComboBox();
            this.dtp_tp1_fechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tp1_Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tp1_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tp1_DPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_tp2_monto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_tp2_FinCober = new System.Windows.Forms.DateTimePicker();
            this.dtp_tp2_IniCober = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tp2_telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_tp2_Cober = new System.Windows.Forms.ComboBox();
            this.dtp_tp2_fnacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tp2_nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tp2_DPI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 377);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_tp0_modificar);
            this.tabPage1.Controls.Add(this.btn_tp0_agregar);
            this.tabPage1.Controls.Add(this.btn_tp0_EliminarAfi);
            this.tabPage1.Controls.Add(this.btn_tp0_buscar);
            this.tabPage1.Controls.Add(this.btn_tp0_BuscarAfi);
            this.tabPage1.Controls.Add(this.txt_tp0_BusquedaId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busqueda de Filiados";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_tp0_modificar
            // 
            this.btn_tp0_modificar.Location = new System.Drawing.Point(168, 81);
            this.btn_tp0_modificar.Name = "btn_tp0_modificar";
            this.btn_tp0_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_modificar.TabIndex = 14;
            this.btn_tp0_modificar.Text = "Modificar";
            this.btn_tp0_modificar.UseVisualStyleBackColor = true;
            this.btn_tp0_modificar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_tp0_agregar
            // 
            this.btn_tp0_agregar.Location = new System.Drawing.Point(6, 81);
            this.btn_tp0_agregar.Name = "btn_tp0_agregar";
            this.btn_tp0_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_agregar.TabIndex = 13;
            this.btn_tp0_agregar.Text = "Nuevo";
            this.btn_tp0_agregar.UseVisualStyleBackColor = true;
            this.btn_tp0_agregar.Click += new System.EventHandler(this.btn_tp0_agregar_Click);
            // 
            // btn_tp0_EliminarAfi
            // 
            this.btn_tp0_EliminarAfi.Location = new System.Drawing.Point(87, 81);
            this.btn_tp0_EliminarAfi.Name = "btn_tp0_EliminarAfi";
            this.btn_tp0_EliminarAfi.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_EliminarAfi.TabIndex = 12;
            this.btn_tp0_EliminarAfi.Text = "Eliminar";
            this.btn_tp0_EliminarAfi.UseVisualStyleBackColor = true;
            this.btn_tp0_EliminarAfi.Click += new System.EventHandler(this.btn_EliminarAfi_Click_1);
            // 
            // btn_tp0_buscar
            // 
            this.btn_tp0_buscar.Location = new System.Drawing.Point(784, 81);
            this.btn_tp0_buscar.Name = "btn_tp0_buscar";
            this.btn_tp0_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_buscar.TabIndex = 7;
            this.btn_tp0_buscar.Text = "Ver Todos";
            this.btn_tp0_buscar.UseVisualStyleBackColor = true;
            this.btn_tp0_buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_tp0_BuscarAfi
            // 
            this.btn_tp0_BuscarAfi.Location = new System.Drawing.Point(281, 22);
            this.btn_tp0_BuscarAfi.Name = "btn_tp0_BuscarAfi";
            this.btn_tp0_BuscarAfi.Size = new System.Drawing.Size(75, 23);
            this.btn_tp0_BuscarAfi.TabIndex = 6;
            this.btn_tp0_BuscarAfi.Text = "Buscar";
            this.btn_tp0_BuscarAfi.UseVisualStyleBackColor = true;
            this.btn_tp0_BuscarAfi.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_tp0_BusquedaId
            // 
            this.txt_tp0_BusquedaId.Location = new System.Drawing.Point(56, 24);
            this.txt_tp0_BusquedaId.Name = "txt_tp0_BusquedaId";
            this.txt_tp0_BusquedaId.Size = new System.Drawing.Size(201, 20);
            this.txt_tp0_BusquedaId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DPI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 235);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_tp1_Telefono);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btn_tp1_agregarAfi);
            this.tabPage2.Controls.Add(this.combo_tp1_Cober);
            this.tabPage2.Controls.Add(this.dtp_tp1_fechaNaci);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_tp1_Apellido);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_tp1_Nombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_tp1_DPI);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Afiliados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_tp1_Telefono
            // 
            this.txt_tp1_Telefono.Location = new System.Drawing.Point(124, 127);
            this.txt_tp1_Telefono.Name = "txt_tp1_Telefono";
            this.txt_tp1_Telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_tp1_Telefono.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefono:";
            // 
            // btn_tp1_agregarAfi
            // 
            this.btn_tp1_agregarAfi.Location = new System.Drawing.Point(86, 249);
            this.btn_tp1_agregarAfi.Name = "btn_tp1_agregarAfi";
            this.btn_tp1_agregarAfi.Size = new System.Drawing.Size(170, 23);
            this.btn_tp1_agregarAfi.TabIndex = 16;
            this.btn_tp1_agregarAfi.Text = "Agregar";
            this.btn_tp1_agregarAfi.UseVisualStyleBackColor = true;
            this.btn_tp1_agregarAfi.Click += new System.EventHandler(this.btn_agregarAfi_Click);
            // 
            // combo_tp1_Cober
            // 
            this.combo_tp1_Cober.FormattingEnabled = true;
            this.combo_tp1_Cober.Location = new System.Drawing.Point(124, 161);
            this.combo_tp1_Cober.Name = "combo_tp1_Cober";
            this.combo_tp1_Cober.Size = new System.Drawing.Size(121, 21);
            this.combo_tp1_Cober.TabIndex = 15;
            this.combo_tp1_Cober.Text = "Selecciona uno:";
            this.combo_tp1_Cober.SelectedIndexChanged += new System.EventHandler(this.comCober_SelectedIndexChanged);
            // 
            // dtp_tp1_fechaNaci
            // 
            this.dtp_tp1_fechaNaci.CustomFormat = "yyyy-MM-dd";
            this.dtp_tp1_fechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tp1_fechaNaci.Location = new System.Drawing.Point(124, 194);
            this.dtp_tp1_fechaNaci.Name = "dtp_tp1_fechaNaci";
            this.dtp_tp1_fechaNaci.Size = new System.Drawing.Size(200, 20);
            this.dtp_tp1_fechaNaci.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Nacimiento:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Cobertura:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_tp1_Apellido
            // 
            this.txt_tp1_Apellido.Location = new System.Drawing.Point(124, 96);
            this.txt_tp1_Apellido.Name = "txt_tp1_Apellido";
            this.txt_tp1_Apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_tp1_Apellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // txt_tp1_Nombre
            // 
            this.txt_tp1_Nombre.Location = new System.Drawing.Point(124, 61);
            this.txt_tp1_Nombre.Name = "txt_tp1_Nombre";
            this.txt_tp1_Nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_tp1_Nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // txt_tp1_DPI
            // 
            this.txt_tp1_DPI.Location = new System.Drawing.Point(124, 25);
            this.txt_tp1_DPI.Name = "txt_tp1_DPI";
            this.txt_tp1_DPI.Size = new System.Drawing.Size(200, 20);
            this.txt_tp1_DPI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DPI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_tp2_monto);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dtp_tp2_FinCober);
            this.tabPage3.Controls.Add(this.dtp_tp2_IniCober);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txt_tp2_telefono);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.combo_tp2_Cober);
            this.tabPage3.Controls.Add(this.dtp_tp2_fnacimiento);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_tp2_nombre);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txt_tp2_DPI);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 351);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Modificar Afiliado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_tp2_monto
            // 
            this.txt_tp2_monto.Location = new System.Drawing.Point(479, 103);
            this.txt_tp2_monto.Name = "txt_tp2_monto";
            this.txt_tp2_monto.Size = new System.Drawing.Size(200, 20);
            this.txt_tp2_monto.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Monto: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // dtp_tp2_FinCober
            // 
            this.dtp_tp2_FinCober.CustomFormat = "yyyy-MM-dd";
            this.dtp_tp2_FinCober.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tp2_FinCober.Location = new System.Drawing.Point(479, 71);
            this.dtp_tp2_FinCober.Name = "dtp_tp2_FinCober";
            this.dtp_tp2_FinCober.Size = new System.Drawing.Size(200, 20);
            this.dtp_tp2_FinCober.TabIndex = 34;
            // 
            // dtp_tp2_IniCober
            // 
            this.dtp_tp2_IniCober.CustomFormat = "yyyy-MM-dd";
            this.dtp_tp2_IniCober.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tp2_IniCober.Location = new System.Drawing.Point(479, 35);
            this.dtp_tp2_IniCober.Name = "dtp_tp2_IniCober";
            this.dtp_tp2_IniCober.Size = new System.Drawing.Size(200, 20);
            this.dtp_tp2_IniCober.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Fin de cobertura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Inicio de Cobertura";
            // 
            // txt_tp2_telefono
            // 
            this.txt_tp2_telefono.Location = new System.Drawing.Point(137, 110);
            this.txt_tp2_telefono.Name = "txt_tp2_telefono";
            this.txt_tp2_telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_tp2_telefono.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefono:";
            // 
            // combo_tp2_Cober
            // 
            this.combo_tp2_Cober.FormattingEnabled = true;
            this.combo_tp2_Cober.Location = new System.Drawing.Point(137, 144);
            this.combo_tp2_Cober.Name = "combo_tp2_Cober";
            this.combo_tp2_Cober.Size = new System.Drawing.Size(121, 21);
            this.combo_tp2_Cober.TabIndex = 28;
            this.combo_tp2_Cober.Text = "Selecciona uno:";
            // 
            // dtp_tp2_fnacimiento
            // 
            this.dtp_tp2_fnacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtp_tp2_fnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tp2_fnacimiento.Location = new System.Drawing.Point(137, 177);
            this.dtp_tp2_fnacimiento.Name = "dtp_tp2_fnacimiento";
            this.dtp_tp2_fnacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_tp2_fnacimiento.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tipo de Cobertura:";
            // 
            // txt_tp2_nombre
            // 
            this.txt_tp2_nombre.Location = new System.Drawing.Point(137, 70);
            this.txt_tp2_nombre.Name = "txt_tp2_nombre";
            this.txt_tp2_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_tp2_nombre.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nombre:";
            // 
            // txt_tp2_DPI
            // 
            this.txt_tp2_DPI.Location = new System.Drawing.Point(137, 34);
            this.txt_tp2_DPI.Name = "txt_tp2_DPI";
            this.txt_tp2_DPI.ReadOnly = true;
            this.txt_tp2_DPI.Size = new System.Drawing.Size(200, 20);
            this.txt_tp2_DPI.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "DPI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mantenimiento de Afiliados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_tp0_BuscarAfi;
        private System.Windows.Forms.TextBox txt_tp0_BusquedaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_tp1_fechaNaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tp1_Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tp1_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tp1_DPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_tp1_Cober;
        private System.Windows.Forms.Button btn_tp1_agregarAfi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_tp1_Telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_tp0_buscar;
        private System.Windows.Forms.Button btn_tp0_EliminarAfi;
        private System.Windows.Forms.Button btn_tp0_agregar;
        private System.Windows.Forms.TextBox txt_tp2_telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_tp2_Cober;
        private System.Windows.Forms.DateTimePicker dtp_tp2_fnacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tp2_nombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tp2_DPI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_tp2_FinCober;
        private System.Windows.Forms.DateTimePicker dtp_tp2_IniCober;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tp0_modificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tp2_monto;
    }
}

