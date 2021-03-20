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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {

            try { 
            int suma;
            suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

            txtResultado.Text = suma.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show("Tus datos no son correctos, por favor ingresar numeros enteros "+ex.ToString());

            }
            //txtResultado.Text = txtDato1.Text + txtDato2.Text;
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            try
            {
                int resta;
                resta = Convert.ToInt32(txtDato1.Text) - Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = resta.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tus datos no son correctos, por favor ingresar numeros enteros " + ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int multi;
                multi = Convert.ToInt32(txtDato1.Text) * Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = multi.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tus datos no son correctos, por favor ingresar numeros enteros " + ex.ToString());

            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int divi;
                divi = Convert.ToInt32(txtDato1.Text) / Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = divi.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tus datos no son correctos, por favor ingresar numeros enteros " + ex.ToString());

            }
        }
    }
}
