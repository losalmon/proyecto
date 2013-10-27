using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class CtrlCliente:Dal.TDatosSql
    {
        public bool GuardarCliente(Negocio.Cliente objcliente)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcliente.guardar(ref t))
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
        public bool ModificarCliente(Negocio.Cliente objcliente)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcliente.modificar(ref t))
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
        public bool EliminarCliente(Negocio.Cliente objcliente)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcliente.eliminar(ref t))
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
        public bool GuardarComprador(Negocio.Comprador objcomprador)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcomprador.guardar(ref t))
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
        public bool ModificarComprador(Negocio.Comprador objcomprador)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcomprador.modificar(ref t))
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
        public bool EliminarComprador(Negocio.Comprador objcomprador)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objcomprador.eliminar(ref t))
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
