using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Producto:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idproducto { set; get; }
        public string Tipo_producto { set; get; }
        public string Caracteristicas { set; get; }
        public long Precio { set; get; }
        public long Stock { set; get; }
        public Int64 Idfabricante { set; get; }
        #endregion

        #region "metodos"
        public bool guardar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "insert into Producto values(#Idproducto,'#Tipo_producto','#Caracteristicas',#Precio,#Stock,#Idfabricante)";
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            strcad = strcad.Replace("#Tipo_producto", this.Tipo_producto.ToString());
            strcad = strcad.Replace("#Caracteristicas", this.Caracteristicas.ToString());
            strcad = strcad.Replace("#Precio", this.Precio.ToString());
            strcad = strcad.Replace("#Stock", this.Stock.ToString());
            strcad = strcad.Replace("#Idfabricante", this.Idfabricante.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool modificar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "update Producto set Tipo_producto='#Tipo_producto', Caracteristicas='#Caracteristicas', Precio=#Precio, Stock=#Stock, Idfabricante=#Idfabricante where Idproducto=#Idproducto";
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            strcad = strcad.Replace("#Tipo_producto", this.Tipo_producto.ToString());
            strcad = strcad.Replace("#Caracteristicas", this.Caracteristicas.ToString());
            strcad = strcad.Replace("#Precio", this.Precio.ToString());
            strcad = strcad.Replace("#Stock", this.Stock.ToString());
            strcad = strcad.Replace("#Idfabricante", this.Idfabricante.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool eliminar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "delete from Producto where Idproducto=#Idproducto";
            strcad = strcad.Replace("#Idproducto", this.Idproducto.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public DataTable traer_producto()
        {
            if (this.Idproducto == 0)
            {
                return this.TraerDataTablestrSql("select * from Producto");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Producto where Idproducto = " + this.Idproducto.ToString());
            }
        }
        public DataTable traer_productogeneralpornombre(string Nombre_producto)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_producto;
            return this.TraerDataTable("sp_traer_productoPorNombre", args);
        }
        public DataTable traer_productoPorFabricante()
        {
            System.Object[] args = new System.Object[1];
            args[0] = Idproducto;
            return this.TraerDataTable("sp_traer_productoPorTipo", args);
        }
        public DataTable traer_productoGeneral()
        {
            System.Object[] args = new System.Object[1];
            args[0] = Idproducto;
            return this.TraerDataTable("sp_traer_productoGeneral", args);
        }
        #endregion
    }
}
