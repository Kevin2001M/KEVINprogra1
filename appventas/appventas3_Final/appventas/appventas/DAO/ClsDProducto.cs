using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDProducto
    {
        public List<tb_producto> CargarProducto(string filtro)
        {

            List<tb_producto> tb_producto = new List<tb_producto>();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto = (from listadproductos in db.tb_producto
                               where listadproductos.nombreProducto.Contains(filtro)
                               select listadproductos).ToList();

            }

            return tb_producto;
        }

        public List<tb_producto> BuscarProducto(int codigo)
        {

            List<tb_producto> tb_producto = new List<tb_producto>();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto = (from listadproductos in db.tb_producto
                               where listadproductos.idProducto == codigo
                               select listadproductos).ToList();

            }

            return tb_producto;
        }
    }
}
