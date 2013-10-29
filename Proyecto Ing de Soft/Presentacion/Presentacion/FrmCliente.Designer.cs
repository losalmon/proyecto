namespace Presentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txbidcomprador = new System.Windows.Forms.TextBox();
            this.lblid_comp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbcomprador = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.lblcomprador = new System.Windows.Forms.Label();
            this.txbidcliente = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txbtelf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbnit = new System.Windows.Forms.TextBox();
            this.txbapp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbapm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbidcomprador
            // 
            this.txbidcomprador.Enabled = false;
            this.txbidcomprador.Location = new System.Drawing.Point(170, 37);
            this.txbidcomprador.Name = "txbidcomprador";
            this.txbidcomprador.Size = new System.Drawing.Size(50, 20);
            this.txbidcomprador.TabIndex = 87;
            this.txbidcomprador.Visible = false;
            // 
            // lblid_comp
            // 
            this.lblid_comp.AutoSize = true;
            this.lblid_comp.Location = new System.Drawing.Point(157, 21);
            this.lblid_comp.Name = "lblid_comp";
            this.lblid_comp.Size = new System.Drawing.Size(72, 13);
            this.lblid_comp.TabIndex = 86;
            this.lblid_comp.Text = "ID Comprador";
            this.lblid_comp.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbcomprador);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txbbuscar);
            this.groupBox1.Controls.Add(this.txbidcomprador);
            this.groupBox1.Controls.Add(this.lblcomprador);
            this.groupBox1.Controls.Add(this.txbidcliente);
            this.groupBox1.Controls.Add(this.lblid_comp);
            this.groupBox1.Controls.Add(this.lblbuscar);
            this.groupBox1.Controls.Add(this.txbtelf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbnombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txbnit);
            this.groupBox1.Controls.Add(this.txbapp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbapm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 197);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cbcomprador
            // 
            this.cbcomprador.AutoSize = true;
            this.cbcomprador.Enabled = false;
            this.cbcomprador.Location = new System.Drawing.Point(127, 169);
            this.cbcomprador.Name = "cbcomprador";
            this.cbcomprador.Size = new System.Drawing.Size(15, 14);
            this.cbcomprador.TabIndex = 108;
            this.cbcomprador.UseVisualStyleBackColor = true;
            this.cbcomprador.CheckedChanged += new System.EventHandler(this.cbcomprador_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(15, 37);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(108, 20);
            this.txbbuscar.TabIndex = 99;
            this.txbbuscar.TextChanged += new System.EventHandler(this.txbbuscar_TextChanged);
            // 
            // lblcomprador
            // 
            this.lblcomprador.AutoSize = true;
            this.lblcomprador.Location = new System.Drawing.Point(79, 153);
            this.lblcomprador.Name = "lblcomprador";
            this.lblcomprador.Size = new System.Drawing.Size(109, 13);
            this.lblcomprador.TabIndex = 105;
            this.lblcomprador.Text = "¿Vino un Comprador?";
            // 
            // txbidcliente
            // 
            this.txbidcliente.Enabled = false;
            this.txbidcliente.Location = new System.Drawing.Point(266, 37);
            this.txbidcliente.Name = "txbidcliente";
            this.txbidcliente.Size = new System.Drawing.Size(50, 20);
            this.txbidcliente.TabIndex = 97;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(12, 21);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(75, 13);
            this.lblbuscar.TabIndex = 98;
            this.lblbuscar.Text = "Buscar Cliente";
            // 
            // txbtelf
            // 
            this.txbtelf.Enabled = false;
            this.txbtelf.Location = new System.Drawing.Point(141, 118);
            this.txbtelf.Name = "txbtelf";
            this.txbtelf.Size = new System.Drawing.Size(104, 20);
            this.txbtelf.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Telf. Celular";
            // 
            // txbnombre
            // 
            this.txbnombre.Enabled = false;
            this.txbnombre.Location = new System.Drawing.Point(15, 77);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(108, 20);
            this.txbnombre.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "ID Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Nombre";
            // 
            // txbnit
            // 
            this.txbnit.Enabled = false;
            this.txbnit.Location = new System.Drawing.Point(19, 118);
            this.txbnit.Name = "txbnit";
            this.txbnit.Size = new System.Drawing.Size(104, 20);
            this.txbnit.TabIndex = 93;
            // 
            // txbapp
            // 
            this.txbapp.Enabled = false;
            this.txbapp.Location = new System.Drawing.Point(141, 77);
            this.txbapp.Name = "txbapp";
            this.txbapp.Size = new System.Drawing.Size(108, 20);
            this.txbapp.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Ap. Paterno";
            // 
            // txbapm
            // 
            this.txbapm.Enabled = false;
            this.txbapm.Location = new System.Drawing.Point(266, 77);
            this.txbapm.Name = "txbapm";
            this.txbapm.Size = new System.Drawing.Size(108, 20);
            this.txbapm.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Ap. Materno";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnguardar,
            this.btnmodificar,
            this.btneliminar,
            this.btnimprimir,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(17, 212);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 108;
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
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
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
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 189);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbidcomprador;
        private System.Windows.Forms.Label lblid_comp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbcomprador;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.TextBox txbidcliente;
        private System.Windows.Forms.Label lblcomprador;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnit;
        private System.Windows.Forms.TextBox txbtelf;
        private System.Windows.Forms.TextBox txbapp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbapm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnguardar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btnimprimir;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}