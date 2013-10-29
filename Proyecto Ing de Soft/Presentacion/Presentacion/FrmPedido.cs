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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 6;
        }

        private void limpiarcontroles()
        {
            this.txbidpedido.Text = "<<Autonumerico>>";
            this.txbidcliente.Text = string.Empty;
            this.txbnombre_cliente.Text = string.Empty;
            this.txbidcomprador.Text = string.Empty;
            this.txbnombre_comprador.Text = string.Empty;
            this.habilitarEntradas();
            this.deshabilitarExtras();
        }

        private void habilitarEntradas()
        {
            dtpfecha_pedido.Enabled = true;
            btnguardar.Enabled = true;
            btnañadir.Enabled = true;
            btnimprimir.Enabled = true;
        }
        private void deshabilitarEntradas()
        {
            btnguardar.Enabled = false;
            btnañadir.Enabled = false;
            btnimprimir.Enabled = false;
        }

        private void habilitarExtras()
        {
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
        }

        private void deshabilitarExtras()
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnbuscarcomprador_Click(object sender, EventArgs e)
        {
            FrmBuscarComprador objfrmbuscar = new FrmBuscarComprador();
            objfrmbuscar.ShowDialog();
            this.cargarControlesComprador(Utilitarios.Utilitarios.Idcomprador);
        }

        private void cargarControlesComprador(long Idcomprador)
        {
            Negocio.Comprador objcomprador = new Negocio.Comprador();
            objcomprador.Idcomprador = Idcomprador;
            DataTable dtcomprador = objcomprador.traer_comprador();
            this.txbidcomprador.Text = dtcomprador.Rows[0]["Idcomprador"].ToString();
            this.txbnombre_comprador.Text = dtcomprador.Rows[0]["Nombre_comprador"].ToString() + " " + dtcomprador.Rows[0]["App_comp"].ToString() + " " + dtcomprador.Rows[0]["Apm_comp"].ToString();
            this.txbidcliente.Text = dtcomprador.Rows[0]["Idcliente"].ToString();
            this.txbnombre_cliente.Text = dtcomprador.Rows[0]["Nombre_cliente"].ToString() + " " + dtcomprador.Rows[0]["App"].ToString() + " " + dtcomprador.Rows[0]["Apm"].ToString();
        }

        private Int32 fila = -1;

        private void btnañadir_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto objfrmbuscar = new FrmBuscarProducto();
            fila = fila + 1;
            objfrmbuscar.ShowDialog();
            this.cargarControlesProducto();
        }

        private void cargarControlesProducto()
        {
            Negocio.Producto objproducto = new Negocio.Producto();
            DataTable dtproducto = new DataTable();
            objproducto.Idproducto = Utilitarios.Utilitarios.Idproducto;
            dtproducto = objproducto.traer_producto();
            dataGridView1.RowCount = dataGridView1.RowCount + 1;
            this.dataGridView1.Rows[fila].Cells["Id"].Value = dtproducto.Rows[0]["Idproducto"].ToString();
            this.dataGridView1.Rows[fila].Cells["Producto"].Value = dtproducto.Rows[0]["Tipo_producto"].ToString();
            this.dataGridView1.Rows[fila].Cells["Detalles"].Value = dtproducto.Rows[0]["Caracteristicas"].ToString();
            this.dataGridView1.Rows[fila].Cells["Cantidad"].Value = 1;
            this.dataGridView1.Rows[fila].Cells["Precio"].Value = dtproducto.Rows[0]["Precio"].ToString();
            calcularTotal(fila);
        }

        private void calcularTotal(Int32 fila)
        {
            float objPrecio = float.Parse(this.dataGridView1.Rows[fila].Cells["Precio"].Value.ToString());
            float objCantidad = float.Parse(this.dataGridView1.Rows[fila].Cells["Cantidad"].Value.ToString());
            string result = (objPrecio * objCantidad).ToString();
            this.dataGridView1.Rows[fila].Cells["Total"].Value = result;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cbfact.Checked == true)
            {
                double result; decimal aux;
                txbtotal.Text = "0";
                for (int i = 0; i <= fila; i++)
                {
                    calcularTotal(i);
                    result = float.Parse(dataGridView1.Rows[i].Cells["Total"].Value.ToString()) + float.Parse(this.txbtotal.Text);
                    aux = Convert.ToDecimal(result * 0.06 + result);
                    this.txbtotal.Text = (decimal.Truncate(aux)).ToString();
                }
            }
            else
            {
                txbtotal.Text = "0";
                for (int i = 0; i <= fila; i++)
                {
                    calcularTotal(i);
                    this.txbtotal.Text = (float.Parse(dataGridView1.Rows[i].Cells["Total"].Value.ToString()) + float.Parse(this.txbtotal.Text)).ToString();
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Negocio.Pedido objpedido = new Negocio.Pedido();
            this.txbidpedido.Text = objpedido.GenerarCodigo("Pedido", "Idpedido").ToString();
            this.cargarObjetoPedido(ref objpedido);
            Negocio.CtrlPedido objctrlpedido = new Negocio.CtrlPedido();
            if (objctrlpedido.GuardarPedido(objpedido))
            {
                MessageBox.Show("Pedido registrado...!!!");
                habilitarExtras();
            }
            else
            {
                MessageBox.Show("Error en el registro de pedido");
            }
        }

        private void cargarObjetoPedido(ref Negocio.Pedido objpedido)
        {
            objpedido.Idpedido = long.Parse(this.txbidpedido.Text);
            objpedido.Fecha_pedido = this.dtpfecha_pedido.Text;
            objpedido.Idcliente = long.Parse(this.txbidcliente.Text);
            objpedido.Idcomprador = long.Parse(this.txbidcomprador.Text);
            for (Int32 i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                Negocio.DetallePedido objdetalle = new Negocio.DetallePedido();
                objdetalle.Idpedido = long.Parse(this.txbidpedido.Text);
                objdetalle.Idproducto = long.Parse(dataGridView1.Rows[i].Cells["Id"].Value.ToString());
                objdetalle.Cantidad = long.Parse(dataGridView1.Rows[i].Cells["Cantidad"].Value.ToString());
                objdetalle.Precio_compra = float.Parse(dataGridView1.Rows[i].Cells["Precio"].Value.ToString());
                objpedido.insertarVector(objdetalle);
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            Utilitarios.Utilitarios.Nro_reporte = 5;
            objfrmreporte.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Negocio.Pedido objpedido = new Negocio.Pedido();
            this.cargarObjetoPedido(ref objpedido);
            Negocio.CtrlPedido objctrlpedido = new Negocio.CtrlPedido();
            if (objctrlpedido.ModificarPedido(objpedido))
            {
                MessageBox.Show("Pedido Modificado...!!!");
            }
            else
            {
                MessageBox.Show("Error en la Modificacion del Pedido");
            }
        }

        private void ptbbuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarComprador objfrmbuscar = new FrmBuscarComprador();
            objfrmbuscar.ShowDialog();
            this.cargarControlesComprador(Utilitarios.Utilitarios.Idcomprador);
        }

        private void ptbbuscarproducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto objfrmbuscar = new FrmBuscarProducto();
            fila = fila + 1;
            objfrmbuscar.ShowDialog();
            this.cargarControlesProducto();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            //Negocio.Pedido objpedido = new Negocio.Pedido();
            //this.cargarObjetoPedido(ref objpedido);
            //Negocio.CtrlPedido objctrlpedido = new Negocio.CtrlPedido();
            //if (objctrlpedido.EliminarPedido(objpedido))
            //{
            //    MessageBox.Show("Pedido Eliminado");
            //    limpiarcontroles();
            //}
            //else
            //{
            //    MessageBox.Show("Error en la Eliminacion del Pedido");
            //}
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            FrmBuscarPedido objfrmbuscar = new FrmBuscarPedido();
            objfrmbuscar.ShowDialog();
            this.cargarControlesPedido(Utilitarios.Utilitarios.Idpedido);
        }

        private void cargarControlesPedido(long Idpedido)
        {
            Negocio.Pedido objpedido = new Negocio.Pedido();
            objpedido.Idpedido = Idpedido;
            DataTable dtpedido = objpedido.traer_pedidoPorId(Idpedido);
            this.txbidpedido.Text = dtpedido.Rows[0]["Idpedido"].ToString();
            this.dtpfecha_pedido.Text = dtpedido.Rows[0]["Fecha_pedido"].ToString();
            cargarControlesComprador(long.Parse(dtpedido.Rows[0]["Idcomprador"].ToString()));
        }
    }
}
