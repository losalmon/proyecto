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
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente childForm = new FrmCliente();
            childForm.MdiParent = this;
            childForm.Text = "Cliente " + childFormNumber++;
            childForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmFabricante childForm = new FrmFabricante();
            childForm.MdiParent = this;
            childForm.Text = "Fabricante " + childFormNumber++;
            childForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmProducto childForm = new FrmProducto();
            childForm.MdiParent = this;
            childForm.Text = "Producto " + childFormNumber++;
            childForm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmPedido childForm = new FrmPedido();
            childForm.MdiParent = this;
            childForm.Text = "Pedido " + childFormNumber++;
            childForm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente childForm = new FrmBuscarCliente();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Cliente " + childFormNumber++;
            childForm.Show();
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarComprador childForm = new FrmBuscarComprador();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Comprador " + childFormNumber++;
            childForm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto childForm = new FrmBuscarProducto();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Producto " + childFormNumber++;
            childForm.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 2;
            objfrmreporte.Show();
        }

        private void listadoDeCompradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 3;
            objfrmreporte.Show();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 1;
            objfrmreporte.Show();
        }

        private void listadoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 5;
            objfrmreporte.Show();
        }

        private void listadoDeFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 4;
            objfrmreporte.Show();
        }
    }
}
