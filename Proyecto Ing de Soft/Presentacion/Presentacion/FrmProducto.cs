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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargarcombofabricante();
        }

        private void cargarcombofabricante()
        {
            Negocio.Fabricante objtipo = new Negocio.Fabricante();
            this.cbbfabricante.DataSource = objtipo.traer_fabricante();
            this.cbbfabricante.DisplayMember = "Nombre_fabricante";
            this.cbbfabricante.ValueMember = "Idfabricante";
        }

        private void limpiarcontroles()
        {
            this.txbidproducto.Text = "<<Autonumerico>>";
            this.txbnombre.Text = string.Empty;
            this.txbcaracteristicas.Text = string.Empty;
            this.txbprecio.Text = string.Empty;
            this.txbstock.Text = string.Empty;
        }

        private void habilitarEntradas()
        {
            txbnombre.Enabled = true;
            txbcaracteristicas.Enabled = true;
            txbprecio.Enabled = true;
            txbstock.Enabled = true;
            cbbfabricante.Enabled = true;
            btnguardar.Enabled = true;
            btnimprimir.Enabled = true;
            txbnombre.Focus();
        }

        private void habilitarExtras()
        {
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txbnombre.Focus();
        }

        private void deshabilitarExtras()
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            deshabilitarExtras();
            habilitarEntradas();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            this.txbidproducto.Text = objproducto.generar_id("Producto", "Idproducto").ToString();
            this.cargarobjetoproducto(ref objproducto);
            Negocio.CtrlProducto objctrlproducto = new Negocio.CtrlProducto();
            if (objctrlproducto.GuardarProducto(objproducto))
            {
                MessageBox.Show("Producto Registrado");
            }
            else
            {
                MessageBox.Show("Error en el Registro del Producto");
            }
        }

        private void cargarobjetoproducto(ref Negocio.Producto objproducto)
        {
            objproducto.Idproducto = long.Parse(this.txbidproducto.Text);
            objproducto.Tipo_producto = this.txbnombre.Text;
            objproducto.Caracteristicas = this.txbcaracteristicas.Text;
            objproducto.Precio = long.Parse(this.txbprecio.Text);
            objproducto.Stock = long.Parse(this.txbstock.Text);
            objproducto.Idfabricante = long.Parse(this.cbbfabricante.SelectedValue.ToString());
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            this.cargarobjetoproducto(ref objproducto);
            Negocio.CtrlProducto objctrlproducto = new Negocio.CtrlProducto();
            if (objctrlproducto.ModificarProducto(objproducto))
            {
                MessageBox.Show("Producto Modificado");
                limpiarcontroles();
            }
            else
            {
                MessageBox.Show("Error en la Modificacion del Producto");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            this.cargarobjetoproducto(ref objproducto);
            Negocio.CtrlProducto objctrlproducto = new Negocio.CtrlProducto();
            if (objctrlproducto.EliminarProducto(objproducto))
            {
                MessageBox.Show("Producto Eliminado");
                limpiarcontroles();
            }
            else
            {
                MessageBox.Show("Error en la Eliminacion del Producto");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto objfrmbuscar = new FrmBuscarProducto();
            objfrmbuscar.ShowDialog();
            this.cargarcontroles(Utilitarios.Utilitarios.Idproducto);
            habilitarExtras();
            habilitarEntradas();
        }

        private void cargarcontroles(long Idproducto)
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            objproducto.Idproducto = Idproducto;
            DataTable dtproducto = objproducto.traer_producto();
            this.txbidproducto.Text = dtproducto.Rows[0]["Idproducto"].ToString();
            this.txbnombre.Text = dtproducto.Rows[0]["Tipo_producto"].ToString();
            this.txbcaracteristicas.Text = dtproducto.Rows[0]["Caracteristicas"].ToString();
            this.txbprecio.Text = dtproducto.Rows[0]["Precio"].ToString();
            this.txbstock.Text = dtproducto.Rows[0]["Stock"].ToString();
            Negocio.Fabricante objtipo = new Negocio.Fabricante();
            objtipo.Idfabricante = long.Parse(dtproducto.Rows[0]["Idfabricante"].ToString());
            this.cbbfabricante.Text = objtipo.traer_fabricante().Rows[0]["Nombre_fabricante"].ToString();
            this.cbbfabricante.SelectedValue = long.Parse(dtproducto.Rows[0]["Idfabricante"].ToString());
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 1;
            objfrmreporte.Show();
        }
    }
}
