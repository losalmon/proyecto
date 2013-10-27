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
    public partial class FrmFabricante : Form
    {
        public FrmFabricante()
        {
            InitializeComponent();
        }

        private void limpiarcontroles()
        {
            txbidfabricante.Text = "<<autonumerico>>";
            txbnombre_fab.Text = string.Empty;
        }

        private void habilitarentradas()
        {
            btnguardar.Enabled = true;
            btnimprimir.Enabled = true;
            txbnombre_fab.Enabled = true;
            txbnombre_fab.Focus();
        }

        private void deshabilitarEntradas()
        {
            btnguardar.Enabled = false;
            btnimprimir.Enabled = false;
        }

        private void habilitarExtras()
        {
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txbnombre_fab.Focus();
        }

        private void deshabilitarExtras()
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void cargardatagrid(long Idfabricante)
        {
            Negocio.Fabricante objtipo = new Negocio.Fabricante();
            objtipo.Idfabricante = Idfabricante;
            this.dataGridView1.DataSource = objtipo.traer_fabricante();
        }

        private void cargarobjetofabricante(ref Negocio.Fabricante objfab)
        {
            this.txbidfabricante.Text = objfab.generar_id("Fabricante", "Idfabricante").ToString();
            objfab.Idfabricante = long.Parse(this.txbidfabricante.Text);
            objfab.Nombre_fabricante = this.txbnombre_fab.Text;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            this.cargardatagrid(0);
            deshabilitarExtras();
            habilitarentradas();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Negocio.Fabricante objfab = new Negocio.Fabricante();
            objfab.Idfabricante = long.Parse(this.txbidfabricante.Text);
            objfab.Nombre_fabricante = this.txbnombre_fab.Text;
            if (objfab.modificar())
            {
                MessageBox.Show("Fabricante Modificado !!!");
                this.cargardatagrid(0);
                limpiarcontroles();
                deshabilitarExtras();
            }
            else
            {
                MessageBox.Show("Error al Modificar el Fabricante . . .");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Negocio.Fabricante objfab = new Negocio.Fabricante();
            objfab.Idfabricante = long.Parse(this.txbidfabricante.Text);
            objfab.eliminar();
            this.cargardatagrid(0);
            limpiarcontroles();
            deshabilitarExtras(); 
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            Negocio.Fabricante objfab = new Negocio.Fabricante();
            this.dataGridView1.DataSource = objfab.traer_fabricantePorNombre(this.txbbuscar.Text);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Negocio.Fabricante objfab = new Negocio.Fabricante();
            this.cargarobjetofabricante(ref objfab);
            if (objfab.guardar())
            {
                MessageBox.Show("Fabricante Registrado !!!");
                this.cargardatagrid(0);
                habilitarExtras();
            }
            else
            {
                MessageBox.Show("Error al Registrar el Fabricante . . .");
            }
            deshabilitarEntradas();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txbidfabricante.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idfabricante"].Value.ToString();
            this.txbnombre_fab.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Nombre_fabricante"].Value.ToString();
            habilitarExtras();
            habilitarentradas();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 4;
            objfrmreporte.Show();
        }
    }
}
