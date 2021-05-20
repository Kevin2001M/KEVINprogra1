using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appventas.DAO;
using appventas.VISTA;

namespace appventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsAcceso acce = new ClsAcceso();


            int valor = acce.acceso(txtUsuario.Text, txtPass.Text);

            if(valor == 1)
            {
                FrmVenta venta = new FrmVenta();
                venta.Show();
                //MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Error");
            }
          


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
