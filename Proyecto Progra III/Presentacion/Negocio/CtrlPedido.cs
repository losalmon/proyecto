using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Negocio
{
    public class CtrlPedido:Dal.TDatosSql
    {
        public bool GuardarPedido(Negocio.Pedido objpedido)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objpedido.guardar(ref t))
            {
                for (Int32 i = 0; i <= objpedido.n - 1; i++)
                {
                    Negocio.DetallePedido objdetalle = new DetallePedido();
                    objdetalle = objpedido.leer_vector(i);
                    if (!objdetalle.guardar(ref (t)))
                    {
                        t.Rollback();
                        return false;
                    }
                }
                t.Commit();
                return true;
            }
            t.Rollback();
            return false;
        }
        public bool ModificarPedido(Negocio.Pedido objpedido)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objpedido.modificar(ref t))
            {
                for (Int32 i = 0; i <= objpedido.n - 1; i++)
                {
                    Negocio.DetallePedido objdetalle = new DetallePedido();
                    objdetalle = objpedido.leer_vector(i);
                    if (!objdetalle.modificar(ref (t)))
                    {
                        t.Rollback();
                        return false;
                    }
                }
                t.Commit();
                return true;
            }
            t.Rollback();
            return false;
        }
        public bool EliminarPedido(Negocio.Pedido objpedido)
        {
            System.Data.SqlClient.SqlTransaction t;
            t = this.IniciarTransaccion();
            if (objpedido.eliminar(ref t))
            {
                for (Int32 i = 0; i <= objpedido.n - 1; i++)
                {
                    Negocio.DetallePedido objdetalle = new DetallePedido();
                    objdetalle = objpedido.leer_vector(i);
                    if (!objdetalle.eliminar(ref (t)))
                    {
                        t.Rollback();
                        return false;
                    }
                }
                t.Commit();
                return true;
            }
            t.Rollback();
            return false;
        }
    }
}
