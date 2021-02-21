using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kevin01.DOMINIO;
using Kevin01.NEGOCIO;
using Kevin01.VISTA;

namespace Kevin01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion= clsL.acceso(log);

            if (variabledeevaluacion==1) {

                MessageBox.Show("WELCOME");
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("False");
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

        }
    }
}
