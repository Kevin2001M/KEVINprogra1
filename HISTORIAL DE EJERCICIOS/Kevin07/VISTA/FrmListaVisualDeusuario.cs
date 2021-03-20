using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kevin01.DAO;

namespace Kevin01.VISTA
{
    public partial class FrmListaVisualDeusuario : Form
    {
        public FrmListaVisualDeusuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeusuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            foreach (var iteracion in cls.user) {

                dataGridView1.Rows.Add(iteracion.ToString());
            }

        }
    }
}
