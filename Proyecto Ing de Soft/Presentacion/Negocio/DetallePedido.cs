using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class DetallePedido:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idpedido { set; get; }
        public Int64 Idproducto { set; get; }
        public long Cantidad { set; get; }
        public float Precio_compra { set; get; }
        #endregion

        #region "metodos"
        public bool guardar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "insert into Detalle_Pedido values(#Precio_compra,#Cantidad,#Idpedido,#Idproducto)";
            strcad = strcad.Replace("#Precio_compra", this.Precio_compra.ToString());
            strcad = strcad.Replace("#Cantidad", this.Cantidad.ToString());
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool modificar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "update Detalle_Pedido set Precio_compra=#Precio_compra,Cantidad=#Cantidad where Idpedido=#Idpedido and Idproducto=#Idproducto";
            strcad = strcad.Replace("#Precio_compra", this.Precio_compra.ToString());
            strcad = strcad.Replace("#Cantidad", this.Cantidad.ToString());
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool eliminar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "delete from Detalle_Pedido";
            strcad = strcad.Replace("#Idpedido", this.Idpedido.ToString());
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public DataTable traer_detallePedido()
        {
            if (this.Idpedido == 0 && this.Idproducto == 0)
            {
                return this.TraerDataTablestrSql("select * from Detalle_Pedido");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Detalle_Pedido where Idpedido = " + this.Idpedido.ToString() + " and Idproducto = " + this.Idproducto.ToString());
            }
        }
        public DataTable traer_detallePorNombre(string Nombre_producto)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_producto;
            return this.TraerDataTable("sp_traer_detallePorNombre", args);
        }
        #endregion
    }
}
