namespace Prueba
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresaAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(577, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresaAfiliadoToolStripMenuItem,
            this.ingresoDeProveedoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // ingresaAfiliadoToolStripMenuItem
            // 
            this.ingresaAfiliadoToolStripMenuItem.Name = "ingresaAfiliadoToolStripMenuItem";
            this.ingresaAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresaAfiliadoToolStripMenuItem.Text = "Ingresa Afiliado";
            this.ingresaAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.ingresaAfiliadoToolStripMenuItem_Click);
            // 
            // ingresoDeProveedoresToolStripMenuItem
            // 
            this.ingresoDeProveedoresToolStripMenuItem.Name = "ingresoDeProveedoresToolStripMenuItem";
            this.ingresoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoDeProveedoresToolStripMenuItem.Text = "Ingreso de Proveedores";
            this.ingresoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeProveedoresToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoPrimaToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // pagoPrimaToolStripMenuItem
            // 
            this.pagoPrimaToolStripMenuItem.Name = "pagoPrimaToolStripMenuItem";
            this.pagoPrimaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pagoPrimaToolStripMenuItem.Text = "Pago Prima";
            this.pagoPrimaToolStripMenuItem.Click += new System.EventHandler(this.pagoPrimaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Proyecto Final Web Developer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresaAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoPrimaToolStripMenuItem;
    }
}