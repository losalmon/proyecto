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
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            Negocio.Cliente objcliente = new Negocio.Cliente();
            this.dataGridView1.DataSource = objcliente.traer_clientepornombre(this.txbbuscar.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Idcliente = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcliente"].Value.ToString());
            Utilitarios.Utilitarios.Tipocliente = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Tipo_Cliente"].Value.ToString();
            this.Close();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
