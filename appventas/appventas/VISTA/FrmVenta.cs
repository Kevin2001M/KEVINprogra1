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
using appventas.MODEL;

namespace appventas.VISTA
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

            ClsDClliente clsClliente = new ClsDClliente();
           

                cbCliente.DataSource = clsClliente.CargarComboCliente();
                cbCliente.DisplayMember = "nombreCliente";
                cbCliente.ValueMember = "iDCliente";


            ClsDDocumento clsDocumento = new ClsDDocumento();
              
                cbDocumento.DataSource = clsDocumento.CargaComboDocumento();
                cbDocumento.DisplayMember = "nombreDocumento";
                cbDocumento.ValueMember = "iDDocumento";
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProductos buscar = new FrmProductos();
            buscar.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

