using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Cliente:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idcliente { set; get; }
        public string Nombre_cliente { set; get; }
        public string App { set; get; }
        public string Apm { set; get; }
        public long Nit { set; get; }
        public long Telefono { set; get; }
        #endregion

        #region "metodos"
        public bool guardar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "insert into Cliente values(#Idcliente,'#Nombre_cliente','#App','#Apm',#Nit,#Telefono)";
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            strcad = strcad.Replace("#Nombre_cliente", this.Nombre_cliente.ToString());
            strcad = strcad.Replace("#App", this.App.ToString());
            strcad = strcad.Replace("#Apm", this.Apm.ToString());
            strcad = strcad.Replace("#Nit", this.Nit.ToString());
            strcad = strcad.Replace("#Telefono", this.Telefono.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool modificar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "update Cliente set Nombre_cliente='#Nombre_cliente', App='#App', Apm='#Apm', Nit=#Nit, Telefono=#Telefono where Idcliente=#Idcliente";
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            strcad = strcad.Replace("#Nombre_cliente", this.Nombre_cliente.ToString());
            strcad = strcad.Replace("#App", this.App.ToString());
            strcad = strcad.Replace("#Apm", this.Apm.ToString());
            strcad = strcad.Replace("#Nit", this.Nit.ToString());
            strcad = strcad.Replace("#Telefono", this.Telefono.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool eliminar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "delete from Cliente where Idcliente=#Idcliente";
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public DataTable traer_cliente()
        {
            if (this.Idcliente == 0)
            {
                return this.TraerDataTablestrSql("select * from Cliente");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Cliente where Idcliente = " + this.Idcliente.ToString());
            }
        }
        public DataTable traer_clientepornombre(string Nombre_cliente)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_cliente;
            return this.TraerDataTable("sp_traer_clientePorNombre", args);
        }
        #endregion
    }
}
