namespace Presentacion
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.label5 = new System.Windows.Forms.Label();
            this.txbtotal = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnañadir = new System.Windows.Forms.ToolStripButton();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btnpedido = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbnombre_cliente = new System.Windows.Forms.TextBox();
            this.txbidcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfecha_pedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbidpedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnombre_comprador = new System.Windows.Forms.TextBox();
            this.txbidcomprador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbfact = new System.Windows.Forms.CheckBox();
            this.ptbbuscar = new System.Windows.Forms.PictureBox();
            this.ptbbuscarproducto = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbbuscarproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total :";
            // 
            // txbtotal
            // 
            this.txbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtotal.Location = new System.Drawing.Point(464, 361);
            this.txbtotal.Name = "txbtotal";
            this.txbtotal.Size = new System.Drawing.Size(76, 22);
            this.txbtotal.TabIndex = 50;
            this.txbtotal.Text = "0";
            this.txbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnañadir,
            this.btnguardar,
            this.btnmodificar,
            this.btneliminar,
            this.btnpedido,
            this.btnimprimir,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(19, 117);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(58, 22);
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(58, 22);
            this.btnañadir.Text = "Añadir";
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(66, 22);
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(70, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(63, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnpedido
            // 
            this.btnpedido.Image = ((System.Drawing.Image)(resources.GetObject("btnpedido.Image")));
            this.btnpedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(94, 22);
            this.btnpedido.Text = "Buscar Pedido";
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(65, 22);
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(47, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Detalles,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(15, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 210);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 75;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 75;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 75;
            // 
            // txbnombre_cliente
            // 
            this.txbnombre_cliente.Enabled = false;
            this.txbnombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombre_cliente.Location = new System.Drawing.Point(220, 80);
            this.txbnombre_cliente.Name = "txbnombre_cliente";
            this.txbnombre_cliente.Size = new System.Drawing.Size(171, 20);
            this.txbnombre_cliente.TabIndex = 44;
            // 
            // txbidcliente
            // 
            this.txbidcliente.Enabled = false;
            this.txbidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbidcliente.Location = new System.Drawing.Point(171, 80);
            this.txbidcliente.Name = "txbidcliente";
            this.txbidcliente.Size = new System.Drawing.Size(33, 20);
            this.txbidcliente.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cliente";
            // 
            // dtpfecha_pedido
            // 
            this.dtpfecha_pedido.Enabled = false;
            this.dtpfecha_pedido.Location = new System.Drawing.Point(204, 8);
            this.dtpfecha_pedido.Name = "dtpfecha_pedido";
            this.dtpfecha_pedido.Size = new System.Drawing.Size(210, 20);
            this.dtpfecha_pedido.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha pedido";
            // 
            // txbidpedido
            // 
            this.txbidpedido.Enabled = false;
            this.txbidpedido.Location = new System.Drawing.Point(79, 9);
            this.txbidpedido.Name = "txbidpedido";
            this.txbidpedido.Size = new System.Drawing.Size(33, 20);
            this.txbidpedido.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id Pedido";
            // 
            // txbnombre_comprador
            // 
            this.txbnombre_comprador.Enabled = false;
            this.txbnombre_comprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombre_comprador.Location = new System.Drawing.Point(220, 44);
            this.txbnombre_comprador.Name = "txbnombre_comprador";
            this.txbnombre_comprador.Size = new System.Drawing.Size(171, 20);
            this.txbnombre_comprador.TabIndex = 54;
            // 
            // txbidcomprador
            // 
            this.txbidcomprador.Enabled = false;
            this.txbidcomprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbidcomprador.Location = new System.Drawing.Point(171, 44);
            this.txbidcomprador.Name = "txbidcomprador";
            this.txbidcomprador.Size = new System.Drawing.Size(33, 20);
            this.txbidcomprador.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Comprador";
            // 
            // cbfact
            // 
            this.cbfact.AutoSize = true;
            this.cbfact.Location = new System.Drawing.Point(325, 366);
            this.cbfact.Name = "cbfact";
            this.cbfact.Size = new System.Drawing.Size(53, 17);
            this.cbfact.TabIndex = 111;
            this.cbfact.Text = "FACT";
            this.cbfact.UseVisualStyleBackColor = true;
            // 
            // ptbbuscar
            // 
            this.ptbbuscar.Image = ((System.Drawing.Image)(resources.GetObject("ptbbuscar.Image")));
            this.ptbbuscar.Location = new System.Drawing.Point(35, 39);
            this.ptbbuscar.Name = "ptbbuscar";
            this.ptbbuscar.Size = new System.Drawing.Size(55, 64);
            this.ptbbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbbuscar.TabIndex = 112;
            this.ptbbuscar.TabStop = false;
            this.ptbbuscar.Click += new System.EventHandler(this.ptbbuscar_Click);
            // 
            // ptbbuscarproducto
            // 
            this.ptbbuscarproducto.Image = ((System.Drawing.Image)(resources.GetObject("ptbbuscarproducto.Image")));
            this.ptbbuscarproducto.Location = new System.Drawing.Point(448, 12);
            this.ptbbuscarproducto.Name = "ptbbuscarproducto";
            this.ptbbuscarproducto.Size = new System.Drawing.Size(80, 88);
            this.ptbbuscarproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbbuscarproducto.TabIndex = 113;
            this.ptbbuscarproducto.TabStop = false;
            this.ptbbuscarproducto.Click += new System.EventHandler(this.ptbbuscarproducto_Click);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 397);
            this.Controls.Add(this.ptbbuscarproducto);
            this.Controls.Add(this.ptbbuscar);
            this.Controls.Add(this.cbfact);
            this.Controls.Add(this.txbnombre_comprador);
            this.Controls.Add(this.txbidcomprador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbtotal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbnombre_cliente);
            this.Controls.Add(this.txbidcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfecha_pedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbidpedido);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbbuscarproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbtotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnguardar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btnimprimir;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbnombre_cliente;
        private System.Windows.Forms.TextBox txbidcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfecha_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbidpedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnañadir;
        private System.Windows.Forms.TextBox txbnombre_comprador;
        private System.Windows.Forms.TextBox txbidcomprador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.CheckBox cbfact;
        private System.Windows.Forms.PictureBox ptbbuscar;
        private System.Windows.Forms.PictureBox ptbbuscarproducto;
        private System.Windows.Forms.ToolStripButton btnpedido;
        private System.Windows.Forms.ToolStripButton btneliminar;
    }
}