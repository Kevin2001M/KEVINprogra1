using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appventas.MODEL;

namespace appventas.DAO
{
    class ClsDDocumento
    {
        public List<tb_documento> CargaComboDocumento()
        {
            List<tb_documento> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_documento.ToList();
            }
            return Lista;
        }
    }
}
