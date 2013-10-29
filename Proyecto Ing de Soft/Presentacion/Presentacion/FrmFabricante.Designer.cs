namespace Presentacion
{
    partial class FrmFabricante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabricante));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbidfabricante = new System.Windows.Forms.TextBox();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbnombre_fab = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 205);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbidfabricante);
            this.groupBox1.Controls.Add(this.txbbuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbnombre_fab);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 79);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // txbidfabricante
            // 
            this.txbidfabricante.Enabled = false;
            this.txbidfabricante.Location = new System.Drawing.Point(58, 22);
            this.txbidfabricante.Name = "txbidfabricante";
            this.txbidfabricante.Size = new System.Drawing.Size(48, 20);
            this.txbidfabricante.TabIndex = 11;
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(126, 48);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(108, 20);
            this.txbbuscar.TabIndex = 17;
            this.txbbuscar.TextChanged += new System.EventHandler(this.txbbuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // txbnombre_fab
            // 
            this.txbnombre_fab.Enabled = false;
            this.txbnombre_fab.Location = new System.Drawing.Point(188, 22);
            this.txbnombre_fab.Name = "txbnombre_fab";
            this.txbnombre_fab.Size = new System.Drawing.Size(151, 20);
            this.txbnombre_fab.TabIndex = 13;
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
            this.toolStrip1.Location = new System.Drawing.Point(12, 95);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 21;
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
            // FrmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFabricante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbidfabricante;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbnombre_fab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnguardar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btnimprimir;
        private System.Windows.Forms.ToolStripButton btnsalir;
    }
}