using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class FrmMenuVenta : Form
    {
        public FrmMenuVenta()
        {
            InitializeComponent();
        }

        public static FrmMenu frmVenta = new FrmMenu();

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmVenta frmVenta = new FrmVenta();
            frmVenta.Show();
        }

        private void FrmMenuVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
