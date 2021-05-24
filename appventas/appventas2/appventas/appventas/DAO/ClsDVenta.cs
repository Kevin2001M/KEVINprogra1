using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDVenta
    {
        public List<tb_venta> ultimaventa()
        {
            List<tb_venta> consultaultimaventa = new List<tb_venta>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                consultaultimaventa = bd.tb_venta.ToList();
            }

                return consultaultimaventa;
        }
    }
}
