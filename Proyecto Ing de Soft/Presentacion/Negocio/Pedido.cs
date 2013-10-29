using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Pedido:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idpedido { set; get; }
        public string Fecha_pedido { set; get; }
        public Int64 Idcliente { set; get; }
        public Int64 Idcomprador { set; get; }
        #endregion

        #region "metodos"
        public bool guardar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "insert into Pedido values(#Idpedido,'#Fecha_pedido',#Idcliente,#Idcomprador)";
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            strcad = strcad.Replace("#Fecha_pedido", this.Fecha_pedido.ToString());
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            strcad = strcad.Replace("#Idcomprador", this.Idcomprador.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool modificar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "update Pedido set Fecha_pedido='#Fecha_pedido',Idcliente=#Idcliente,Idcomprador=#Idcomprador where Idpedido=#Idpedido";
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            strcad = strcad.Replace("#Fecha_pedido", this.Fecha_pedido.ToString());
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            strcad = strcad.Replace("#Idcomprador", this.Idcomprador.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool eliminar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "delete from Pedido where Idpedido=#Idpedido";
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public DataTable traer_pedido()
        {
            if (this.Idpedido == 0)
            {
                return this.TraerDataTablestrSql("select * from Pedido");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Pedido where Idpedido = " + this.Idpedido.ToString());
            }
        }
        public DataTable traer_pedidoPorId(long Idpedido)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Idpedido;
            return this.TraerDataTable("sp_traer_pedidoPorId", args);
        }
        public DataTable traer_pedidoGeneral()
        {
            System.Object[] args = new System.Object[1];
            args[0] = Idpedido;
            return this.TraerDataTable("sp_traer_pedidoGeneral", args);
        }
        #endregion

        #region "vector"
        private Negocio.DetallePedido[] V = new DetallePedido[1000];
        public Int32 n { set; get; }
        public void insertarVector(Negocio.DetallePedido objdetalle)
        {
            V[n] = objdetalle;
            n++;
        }
        public Negocio.DetallePedido leer_vector(Int32 pos)
        {
            return V[pos];
        }
        #endregion
    }
}
