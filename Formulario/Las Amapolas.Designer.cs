using System.Diagnostics;

namespace Las_Amapolas.Formulario
{
   partial class Las_Amapolas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitasionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHabitaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regitrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nicioToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.habitasionToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.pagoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nicioToolStripMenuItem
            // 
            this.nicioToolStripMenuItem.Name = "nicioToolStripMenuItem";
            this.nicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.nicioToolStripMenuItem.Text = "Inicio";
            this.nicioToolStripMenuItem.Click += new System.EventHandler(this.nicioToolStripMenuItem_Click);
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHotelToolStripMenuItem});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // registrarHotelToolStripMenuItem
            // 
            this.registrarHotelToolStripMenuItem.Name = "registrarHotelToolStripMenuItem";
            this.registrarHotelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registrarHotelToolStripMenuItem.Text = "Actualizar hotel";
            this.registrarHotelToolStripMenuItem.Click += new System.EventHandler(this.registrarHotelToolStripMenuItem_Click);
            // 
            // habitasionToolStripMenuItem
            // 
            this.habitasionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarHabitaciToolStripMenuItem,
            this.registrarHabitaciónToolStripMenuItem});
            this.habitasionToolStripMenuItem.Name = "habitasionToolStripMenuItem";
            this.habitasionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.habitasionToolStripMenuItem.Text = "Habitación";
            // 
            // buscarHabitaciToolStripMenuItem
            // 
            this.buscarHabitaciToolStripMenuItem.Name = "buscarHabitaciToolStripMenuItem";
            this.buscarHabitaciToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.buscarHabitaciToolStripMenuItem.Text = "Buscar habitación";
            this.buscarHabitaciToolStripMenuItem.Click += new System.EventHandler(this.buscarHabitaciToolStripMenuItem_Click);
            // 
            // registrarHabitaciónToolStripMenuItem
            // 
            this.registrarHabitaciónToolStripMenuItem.Name = "registrarHabitaciónToolStripMenuItem";
            this.registrarHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.registrarHabitaciónToolStripMenuItem.Text = "Registrar habitación";
            this.registrarHabitaciónToolStripMenuItem.Click += new System.EventHandler(this.registrarHabitaciónToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarReservasToolStripMenuItem,
            this.regiToolStripMenuItem});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.reservaToolStripMenuItem.Text = "Reservación";
            // 
            // buscarReservasToolStripMenuItem
            // 
            this.buscarReservasToolStripMenuItem.Name = "buscarReservasToolStripMenuItem";
            this.buscarReservasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarReservasToolStripMenuItem.Text = "Buscar reservación";
            this.buscarReservasToolStripMenuItem.Click += new System.EventHandler(this.buscarReservasToolStripMenuItem_Click);
            // 
            // regiToolStripMenuItem
            // 
            this.regiToolStripMenuItem.Name = "regiToolStripMenuItem";
            this.regiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.regiToolStripMenuItem.Text = "Registrar reservación";
            this.regiToolStripMenuItem.Click += new System.EventHandler(this.regiToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.regitrarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // regitrarClienteToolStripMenuItem
            // 
            this.regitrarClienteToolStripMenuItem.Name = "regitrarClienteToolStripMenuItem";
            this.regitrarClienteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.regitrarClienteToolStripMenuItem.Text = "Regitrar cliente";
            this.regitrarClienteToolStripMenuItem.Click += new System.EventHandler(this.regitrarClienteToolStripMenuItem_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPagoToolStripMenuItem,
            this.hacerPagoToolStripMenuItem});
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pagoToolStripMenuItem.Text = "Pago";
            // 
            // buscarPagoToolStripMenuItem
            // 
            this.buscarPagoToolStripMenuItem.Name = "buscarPagoToolStripMenuItem";
            this.buscarPagoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.buscarPagoToolStripMenuItem.Text = "Buscar pago";
            this.buscarPagoToolStripMenuItem.Click += new System.EventHandler(this.buscarPagoToolStripMenuItem_Click);
            // 
            // hacerPagoToolStripMenuItem
            // 
            this.hacerPagoToolStripMenuItem.Name = "hacerPagoToolStripMenuItem";
            this.hacerPagoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.hacerPagoToolStripMenuItem.Text = "Hacer pago";
            this.hacerPagoToolStripMenuItem.Click += new System.EventHandler(this.hacerPagoToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarFacturaToolStripMenuItem,
            this.facturarToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // buscarFacturaToolStripMenuItem
            // 
            this.buscarFacturaToolStripMenuItem.Name = "buscarFacturaToolStripMenuItem";
            this.buscarFacturaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.buscarFacturaToolStripMenuItem.Text = "Buscar factura";
            this.buscarFacturaToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.facturarToolStripMenuItem.Text = "facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarEmpleadoToolStripMenuItem,
            this.registrarEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar empleado";
            this.buscarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.buscarEmpleadoToolStripMenuItem_Click);
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(3, 88);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(812, 414);
            this.contenedor.TabIndex = 2;
            // 
            // Las_Amapolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 505);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Las_Amapolas";
            this.Text = "Las Amapolas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Las_Amapolas_FormClosed);
            this.Load += new System.EventHandler(this.Las_Amapolas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitasionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHabitaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHabitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nicioToolStripMenuItem;
        public System.Windows.Forms.Panel contenedor;



    }
}