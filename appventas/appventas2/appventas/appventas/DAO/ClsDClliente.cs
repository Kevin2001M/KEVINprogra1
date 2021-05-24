using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDClliente
    {
        public List<tb_cliente> CargarComboCliente()
        {
            List<tb_cliente> tb_Clientes = new List<tb_cliente>();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_Clientes = db.tb_cliente.ToList();

            }

                return tb_Clientes;
        }
    }
}
