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
            this.CenterToScreen();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clslog = new ClsLogin();
            FrmMenu menu = new FrmMenu();

            int variabledeevaluacion = clslog.accesoBidimecional(log);


            if (variabledeevaluacion == 1)
            {
                MessageBox.Show("Enter");
                FrmMenu frm = new FrmMenu();
                frm.usuarioEstado = txtUser.Text;
                frm.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
