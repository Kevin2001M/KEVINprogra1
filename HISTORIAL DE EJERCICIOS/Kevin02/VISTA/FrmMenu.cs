﻿using System;
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

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
