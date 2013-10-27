using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Fabricante:Dal.TDatosSql
    {
        #region "atributos"
        public Int64 Idfabricante { set; get; }
        public string Nombre_fabricante { set; get; }
        #endregion

        #region "metodos"
        public bool guardar()
        {
            string strcad = "insert into Fabricante values(#Idfabricante,'#Nombre_fabricante')";
            strcad = strcad.Replace("#Idfabricante", this.Idfabricante.ToString());
            strcad = strcad.Replace("#Nombre_fabricante", this.Nombre_fabricante.ToString());
            return this.ejecutarDML(strcad) == 1;
        }
        public bool modificar()
        {
            string strcad = "update Fabricante set Nombre_fabricante='#Nombre_fabricante' where Idfabricante=#Idfabricante";
            strcad = strcad.Replace("#Idfabricante", this.Idfabricante.ToString());
            strcad = strcad.Replace("#Nombre_fabricante", this.Nombre_fabricante.ToString());
            return this.ejecutarDML(strcad) == 1;
        }
        public bool eliminar()
        {
            string strcad = "delete from Fabricante where Idfabricante=#Idfabricante";
            strcad = strcad.Replace("#Idfabricante", this.Idfabricante.ToString());
            return this.ejecutarDML(strcad) == 1;
        }
        public DataTable traer_fabricante()
        {
            if (this.Idfabricante == 0)
            {
                return this.TraerDataTablestrSql("select * from Fabricante");
            }
            else
            {
                return this.TraerDataTablestrSql("select * from Fabricante where Idfabricante = " + this.Idfabricante.ToString());
            }
        }
        public DataTable traer_fabricantePorNombre(string Nombre_fabricante)
        {
            System.Object[] args = new System.Object[1];
            args[0] = Nombre_fabricante;
            return this.TraerDataTable("sp_traer_fabricantePorNombre", args);
        }
        public DataTable traer_fabricanteGeneral()
        {
            System.Object[] args = new System.Object[1];
            args[0] = Idfabricante;
            return this.TraerDataTable("sp_traer_fabricanteGeneral", args);
        }
        #endregion
    }
}
