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
    public partial class FrmBuscarComprador : Form
    {
        public FrmBuscarComprador()
        {
            InitializeComponent();
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            Negocio.Comprador objcomprador = new Negocio.Comprador();
            this.dataGridView1.DataSource = objcomprador.traer_compradorpornombre(this.txbbuscar.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Idcomprador = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcomprador"].Value.ToString());
            Utilitarios.Utilitarios.Idcliente = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcliente"].Value.ToString());
            this.Close();
        }

        private void FrmBuscarComprador_Load(object sender, EventArgs e)
        {

        }
    }
}
