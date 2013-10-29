using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Presentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.mostrarReporte(Utilitarios.Utilitarios.Nro_reporte);
            this.reportViewer1.RefreshReport();
        }

        private void mostrarReporte(Int32 Nro_reporte)
        {
            ReportDataSource Repordatsource1 = new ReportDataSource();
            switch (Nro_reporte)
            {
                case 1: //LISTADO DE PRODUCTOS
                    Negocio.Producto objproducto = new Negocio.Producto();
                    objproducto.Idproducto = Utilitarios.Utilitarios.Idproducto;
                    Repordatsource1.Name = "DataSetProducto";
                    Repordatsource1.Value = objproducto.traer_productoGeneral();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Repordatsource1);
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.Utilitarios.Ruta_rpte + "RptListadoProductos.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 2: //LISTADO DE CLIENTE GENERAL
                    Negocio.Cliente objcliente = new Negocio.Cliente();
                    Repordatsource1.Name = "DataSetCliente";
                    Repordatsource1.Value = objcliente.traer_clientepornombre("");
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Repordatsource1);
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.Utilitarios.Ruta_rpte + "RptListadoClientes.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 3: //LISTADO DE COMPRADOR
                    Negocio.Comprador objcomprador = new Negocio.Comprador();
                    objcomprador.Idcomprador = Utilitarios.Utilitarios.Idcomprador;
                    Repordatsource1.Name = "DataSetCliente";
                    Repordatsource1.Value = objcomprador.traer_compradorpornombre("");
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Repordatsource1);
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.Utilitarios.Ruta_rpte + "RptListadoCompradores.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 4: //LISTADO DE FABRICANTES DE PRODUCTOS
                    Negocio.Fabricante objfabricante = new Negocio.Fabricante();
                    Repordatsource1.Name = "DataSetProducto";
                    Repordatsource1.Value = objfabricante.traer_fabricanteGeneral();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Repordatsource1);
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.Utilitarios.Ruta_rpte + "RptListadoFabricante.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 5: //LISTADO DE PEDIDOS
                    Negocio.Pedido objpedido = new Negocio.Pedido();
                    objpedido.Idpedido = Utilitarios.Utilitarios.Idpedido;
                    Repordatsource1.Name = "DataSetPedido";
                    Repordatsource1.Value = objpedido.traer_pedidoGeneral();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Repordatsource1);
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.Utilitarios.Ruta_rpte + "RptListadoPedidos.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                default:
                    break;
            }
        }
    }
}
