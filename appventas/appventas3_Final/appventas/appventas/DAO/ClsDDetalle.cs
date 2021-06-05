using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDDetalle
    {
        public void guardardetalleventa(tb_detalleVenta detalle)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_detalleVenta tbDetalleVenta = new tb_detalleVenta();
                tbDetalleVenta.iDVenta = detalle.iDVenta;   
                tbDetalleVenta.iDProducto = detalle.iDProducto;
                tbDetalleVenta.cantidad = detalle.cantidad;
                tbDetalleVenta.precio = detalle.precio;
                tbDetalleVenta.total = detalle.total;
                db.tb_detalleVenta.Add(tbDetalleVenta);
                db.SaveChanges();
            }
        }
    }
}
