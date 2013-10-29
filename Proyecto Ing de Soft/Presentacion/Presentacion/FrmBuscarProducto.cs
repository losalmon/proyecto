using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            this.dataGridView1.DataSource = objproducto.traer_productogeneralpornombre(this.txbbuscar.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Idproducto = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idproducto"].Value.ToString());
            Utilitarios.Utilitarios.Tipo_producto = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Tipo_producto"].Value.ToString();
            this.Close();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            this.cargarComboFabricante();
        }

        private void cargarComboFabricante()
        {
            Negocio.Fabricante objfabricante = new Negocio.Fabricante();
            this.cbbfabricante.DataSource = objfabricante.traer_fabricante();
            this.cbbfabricante.DisplayMember = "Nombre_fabricante";
            this.cbbfabricante.ValueMember = "Idfabricante";
        }

        private void cbbfabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            objproducto.Idproducto = this.cbbfabricante.SelectedIndex + 1;
            this.dataGridView1.DataSource = objproducto.traer_productoPorFabricante();
        }
    }
}
