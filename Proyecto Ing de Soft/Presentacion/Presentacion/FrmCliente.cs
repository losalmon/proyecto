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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void limpiarcontroles()
        {
            this.txbbuscar.Text = string.Empty;
            this.txbidcliente.Text = "<<Autonumerico>>";
            this.txbidcomprador.Text = "<<Autonumerico>>";
            this.txbnombre.Text = string.Empty;
            this.txbapp.Text = string.Empty;
            this.txbapm.Text = string.Empty;
            this.txbnit.Text = string.Empty;
            this.txbtelf.Text = string.Empty;
        }

        private void habilitarentradas()
        {
            btnguardar.Enabled = true;
            btnimprimir.Enabled = true;
            txbnombre.Enabled = true;
            txbapp.Enabled = true;
            txbapm.Enabled = true;
            txbnit.Enabled = true;
            txbtelf.Enabled = true;
            txbnombre.Focus();
        }

        private void habilitarextras()
        {
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txbnombre.Focus();
        }

        private void deshabilitarextras()
        {
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void cambiartipo()
        {
            txbidcomprador.Visible = true;
            lblid_comp.Visible = true;
            lblbuscar.Text = "Buscar Comprador";
            groupBox1.Text = "Comprador";
        }

        private void descambiartipo()
        {
            txbidcomprador.Visible = false;
            lblid_comp.Visible = false;
            lblbuscar.Text = "Buscar Cliente";
            groupBox1.Text = "Cliente";
        }

        private void cargarobjetocliente(ref Negocio.Cliente objcliente)
        {
            objcliente.Idcliente = long.Parse(this.txbidcliente.Text);
            objcliente.Nombre_cliente = this.txbnombre.Text;
            objcliente.App = this.txbapp.Text;
            objcliente.Apm = this.txbapm.Text;
            objcliente.Nit = long.Parse(this.txbnit.Text);
            objcliente.Telefono = long.Parse(this.txbtelf.Text);
        }

        private void cargarobjetocomprador(ref Negocio.Comprador objcomprador)
        {
            objcomprador.Idcomprador = long.Parse(this.txbidcomprador.Text);
            objcomprador.Nombre_comprador = this.txbnombre.Text;
            objcomprador.App_comp = this.txbapp.Text;
            objcomprador.Apm_comp = this.txbapm.Text;
            objcomprador.Nit_comp = long.Parse(this.txbnit.Text);
            objcomprador.Telefono_comp = long.Parse(this.txbtelf.Text);
            objcomprador.Idcliente = long.Parse(this.txbidcliente.Text);
        }

        private void cargardatagrid1(long Idcliente)
        {
            Negocio.Cliente objcliente = new Negocio.Cliente();
            objcliente.Idcliente = Idcliente;
            this.dataGridView1.DataSource = objcliente.traer_cliente();
        }

        private void cargardatagrid2(long Idcomprador)
        {
            Negocio.Comprador objcomprador = new Negocio.Comprador();
            objcomprador.Idcomprador = Idcomprador;
            this.dataGridView1.DataSource = objcomprador.traer_compradorporidcliente();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == true)
            {
                conservarid();
                limpiarcontroles();
                deshabilitarextras();
                habilitarentradas();
                this.cargardatagrid2(Utilitarios.Utilitarios.Idcliente);
                txbidcliente.Text = Convert.ToString(Utilitarios.Utilitarios.Idcliente);
            }
            else
            {
                cbcomprador.Enabled = false;
                limpiarcontroles();
                deshabilitarextras();
                habilitarentradas();
                this.cargardatagrid1(0);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == false)
            {
                Negocio.Cliente objcliente = new Negocio.Cliente();
                this.txbidcliente.Text = objcliente.generar_id("cliente", "idcliente").ToString();
                this.cargarobjetocliente(ref objcliente);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.GuardarCliente(objcliente))
                {
                    MessageBox.Show("Cliente Registrado");
                    limpiarcontroles();
                    this.cargardatagrid1(0);
                    habilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en el Registro del Cliente");
                }
            }
            else
            {
                Negocio.Comprador objcomprador = new Negocio.Comprador();
                this.txbidcomprador.Text = objcomprador.generar_id("comprador", "idcomprador").ToString();
                this.cargarobjetocomprador(ref objcomprador);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.GuardarComprador(objcomprador))
                {
                    MessageBox.Show("Comprador Registrado");
                    conservarid();
                    limpiarcontroles();
                    txbidcliente.Text = Convert.ToString(Utilitarios.Utilitarios.Idcliente);
                    this.cargardatagrid2(Utilitarios.Utilitarios.Idcliente);
                    habilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en el Registro del Comprador");
                }
            }
        }

        private void cbcomprador_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == true)
            {
                txbbuscar.Focus();
                cambiartipo();
                conservarid();
                limpiarcontroles();
                txbidcliente.Text = Convert.ToString(Utilitarios.Utilitarios.Idcliente);
                this.cargardatagrid2(Utilitarios.Utilitarios.Idcliente);
                deshabilitarextras();
            }
            else
            {
                txbbuscar.Focus();
                descambiartipo();
                limpiarcontroles();
                this.cargardatagrid1(0);
                cbcomprador.Enabled = false;
                deshabilitarextras();
            }
        }

        private void conservarid()
        {
            Utilitarios.Utilitarios.Idcliente = long.Parse(txbidcliente.Text);
        }

        private void txbbuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == false)
            {
                Negocio.Cliente objcliente = new Negocio.Cliente();
                this.dataGridView1.DataSource = objcliente.traer_clientepornombre(this.txbbuscar.Text);
            }
            else
            {
                Negocio.Comprador objcomprador = new Negocio.Comprador();
                this.dataGridView1.DataSource = objcomprador.traer_compradorpornombre(this.txbbuscar.Text);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == false)
            {
                Utilitarios.Utilitarios.Idcliente = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcliente"].Value.ToString());
                this.cargarcontroles(Utilitarios.Utilitarios.Idcliente);
                habilitarextras();
                habilitarentradas();
            }
            else
            {
                Utilitarios.Utilitarios.Idcomprador = long.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Idcomprador"].Value.ToString());
                this.cargarcontroles(Utilitarios.Utilitarios.Idcomprador);
                habilitarextras();
                habilitarentradas();
            }
        }

        private void cargarcontroles(long id)
        {
            if (this.cbcomprador.Checked == false)
            {
                Negocio.Cliente objcliente = new Negocio.Cliente();
                objcliente.Idcliente = id;
                DataTable dtcliente = objcliente.traer_cliente();
                this.txbidcliente.Text = dtcliente.Rows[0]["Idcliente"].ToString();
                this.txbnombre.Text = dtcliente.Rows[0]["Nombre_cliente"].ToString();
                this.txbapp.Text = dtcliente.Rows[0]["App"].ToString();
                this.txbapm.Text = dtcliente.Rows[0]["Apm"].ToString();
                this.txbnit.Text = dtcliente.Rows[0]["Nit"].ToString();
                this.txbtelf.Text = dtcliente.Rows[0]["Telefono"].ToString();
                cbcomprador.Enabled = true;
            }
            else
            {
                Negocio.Comprador objcomprador = new Negocio.Comprador();
                objcomprador.Idcomprador = id;
                DataTable dtcomprador = new DataTable();
                dtcomprador = objcomprador.traer_comprador();
                this.txbidcomprador.Text = dtcomprador.Rows[0]["Idcomprador"].ToString();
                this.txbnombre.Text = dtcomprador.Rows[0]["Nombre_comprador"].ToString();
                this.txbapp.Text = dtcomprador.Rows[0]["App_comp"].ToString();
                this.txbapm.Text = dtcomprador.Rows[0]["Apm_comp"].ToString();
                this.txbnit.Text = dtcomprador.Rows[0]["Nit_comp"].ToString();
                this.txbtelf.Text = dtcomprador.Rows[0]["Telefono_comp"].ToString();
                this.txbidcliente.Text = dtcomprador.Rows[0]["Idcliente"].ToString();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == false)
            {
                Negocio.Cliente objcliente = new Negocio.Cliente();
                this.cargarobjetocliente(ref objcliente);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.ModificarCliente(objcliente))
                {
                    MessageBox.Show("Cliente Modificado");
                    this.cargardatagrid1(0);
                    limpiarcontroles();
                    deshabilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en la Modificacion del Cliente");
                }
            }
            else
            {
                Negocio.Comprador objcomprador = new Negocio.Comprador();
                this.cargarobjetocomprador(ref objcomprador);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.ModificarComprador(objcomprador))
                {
                    MessageBox.Show("Comprador Modificado");
                    this.cargardatagrid2(0);
                    limpiarcontroles();
                    deshabilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en la Modificacion del Comprador");
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (this.cbcomprador.Checked == false)
            {
                Negocio.Cliente objcliente = new Negocio.Cliente();
                this.cargarobjetocliente(ref objcliente);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.EliminarCliente(objcliente))
                {
                    MessageBox.Show("Cliente Eliminado");
                    this.cargardatagrid1(0);
                    limpiarcontroles();
                    deshabilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en la Eliminacion del Cliente");
                }
            }
            else
            {
                Negocio.Comprador objcomprador = new Negocio.Comprador();
                this.cargarobjetocomprador(ref objcomprador);
                Negocio.CtrlCliente objctrlcliente = new Negocio.CtrlCliente();
                if (objctrlcliente.EliminarComprador(objcomprador))
                {
                    MessageBox.Show("Comprador Eliminado");
                    this.cargardatagrid2(0);
                    limpiarcontroles();
                    deshabilitarextras();
                }
                else
                {
                    MessageBox.Show("Error en la Eliminacion del Comprador");
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporte objfrmreporte = new FrmReporte();
            if (this.cbcomprador.Checked == false)
            {
                if (this.txbidcliente.Text != "<<Autonumerico>>")
                {
                    Utilitarios.Utilitarios.Idcliente = long.Parse(this.txbidcliente.Text);
                    Utilitarios.Utilitarios.Nro_reporte = 2;
                }
                objfrmreporte.ShowDialog();
            }
            else
            {
                if (this.txbidcomprador.Text != "<<Autonumerico>>")
                {
                    Utilitarios.Utilitarios.Idcomprador = long.Parse(this.txbidcomprador.Text);
                    Utilitarios.Utilitarios.Nro_reporte = 3;
                }
                objfrmreporte.ShowDialog();
            }
        }

    }
}
