using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin01.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public String usuarioEstado;
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;
        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mATEMATICASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnResta.Enabled = false;
            frmop.BtnMultiplicar.Enabled = false;
            frmop.BtnDiv.Enabled = false;

            frmop.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnSuma.Enabled = false;
            frmop.BtnMultiplicar.Enabled = false;
            frmop.BtnDiv.Enabled = false;

            frmop.Show();

        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnSuma.Enabled = false;
            frmop.BtnResta.Enabled = false;
            frmop.BtnDiv.Enabled = false;

            frmop.Show();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.BtnSuma.Enabled = false;
            frmop.BtnResta.Enabled = false;
            frmop.BtnMultiplicar.Enabled = false;

            frmop.Show();
        }
    }
}
