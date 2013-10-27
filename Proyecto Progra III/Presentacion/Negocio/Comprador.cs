using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Comprador:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idcomprador { set; get; }
        public string Nombre_comprador { set; get; }
        public string App_comp { set; get; }
        public string Apm_comp { set; get; }
        public long Nit_comp { set; get; }
        public long Telefono_comp { set; get; }
        public Int64 Idcliente { set; get; }
        #endregion

        #region "metodos"
        public bool guardar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "insert into Comprador values(#Idcomprador,'#Nombre_comprador','#App_comp','#Apm_comp',#Nit_comp,#Telefono_comp,#Idcliente)";
            strcad = strcad.Replace("#Idcomprador", this.Idcomprador.ToString());
            strcad = strcad.Replace("#Nombre_comprador", this.Nombre_comprador.ToString());
            strcad = strcad.Replace("#App_comp", this.App_comp.ToString());
            strcad = strcad.Replace("#Apm_comp", this.Apm_comp.ToString());
            strcad = strcad.Replace("#Nit_comp", this.Nit_comp.ToString());
            strcad = strcad.Replace("#Telefono_comp", this.Telefono_comp.ToString());
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool modificar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "update Comprador set Nombre_comprador='#Nombre_comprador', App_comp='#App_comp', Apm_comp='#Apm_comp', Nit_comp=#Nit_comp, Telefono_comp=#Telefono_comp, Idcliente=#Idcliente where Idcomprador=#Idcomprador";
            strcad = strcad.Replace("#Idcomprador", this.Idcomprador.ToString());
            strcad = strcad.Replace("#Nombre_comprador", this.Nombre_comprador.ToString());
            strcad = strcad.Replace("#App_comp", this.App_comp.ToString());
            strcad = strcad.Replace("#Apm_comp", this.Apm_comp.ToString());
            strcad = strcad.Replace("#Nit_comp", this.Nit_comp.ToString());
            strcad = strcad.Replace("#Telefono_comp", this.Telefono_comp.ToString());
            strcad = strcad.Replace("#Idcliente", this.Idcliente.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public bool eliminar(ref System.Data.SqlClient.SqlTransaction t)
        {
            string strcad = "delete from Comprador where Idcomprador=#Idcomprador";
            strcad = strcad.Replace("#Idcomprador", this.Idcomprador.ToString());
            return this.ejecutarDML(strcad, t) == 1;
        }
        public DataTable traer_comprador()
        {
            if (this.Idcomprador == 0)
            {
                return this.TraerDataTablestrSql("select * from Comprador");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Comprador c1,Cliente c2 where c1.Idcliente=c2.Idcliente and Idcomprador = " + this.Idcomprador.ToString());
            }
        }
        public DataTable traer_clientepornombre(string Nombre_cliente)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_cliente;
            return this.TraerDataTable("sp_traer_clientePorNombre", args);
        }
        public DataTable traer_compradorpornombre(string Nombre_comprador)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_comprador;
            return this.TraerDataTable("sp_traer_compradorPorNombre", args);
        }
        public DataTable traer_compradorporidcliente()
        {
            if (this.Idcomprador == 0)
            {
                return this.TraerDataTablestrSql("select * from Comprador");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Comprador where Idcliente = " + (Utilitarios.Utilitarios.Idcliente).ToString());
            }
        }
        #endregion
    }
}
