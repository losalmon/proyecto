using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class CtrlProducto:Dal.TDatosSql
    {
        public bool GuardarProducto(Negocio.Producto objproducto)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objproducto.guardar(ref t))
            {
                t.Commit();     //Confirmar
                return true;
            }
            else
            {
                t.Rollback();   //Desestimar
                return false;
            }
        }
        public bool ModificarProducto(Negocio.Producto objproducto)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objproducto.modificar(ref t))
            {
                t.Commit();
                return true;
            }
            else
            {
                t.Rollback();
                return false;
            }
        }
        public bool EliminarProducto(Negocio.Producto objproducto)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objproducto.eliminar(ref t))
            {
                t.Commit();
                return true;
            }
            else
            {
                t.Rollback();
                return false;
            }
        }
    }
}
