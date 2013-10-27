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
    public partial class FrmBuscarPedido : Form
    {
        public FrmBuscarPedido()
        {
            InitializeComponent();
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            Negocio.Pedido objpedido = new Negocio.Pedido();
            this.dataGridView1.DataSource = objpedido.traer_pedidoPorId(long.Parse(this.txbbuscar.Text));
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Idpedido = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idpedido"].Value.ToString());
            Utilitarios.Utilitarios.Idcliente = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcliente"].Value.ToString());
            this.Close();
        }
    }
}
