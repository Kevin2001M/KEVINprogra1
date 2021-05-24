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
    public partial class txtCal : Form
    {
        public txtCal()
        {
            InitializeComponent();
        }

        //void nose()
        //ClsDVenta consultaprimeraventa = new ClsDVenta();

        void ultimocorrelativodeventa()
        {
            var consultarultimaventa = new ClsDVenta();

            int lista = 0;

            foreach (var list in consultarultimaventa.ultimaventa())
            {
                lista = list.iDVenta;
            }
            lista++;
            txtUltimaVenta.Text = lista.ToString();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            ultimocorrelativodeventa();

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            

          
        }

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            //{
            //    Double precio, cantidad, total;

            //    cantidad = Convert.ToDouble(txtCantidad.Text);
            //    precio = Convert.ToDouble(txtPrecio.Text);

            //    total = precio * cantidad;

            //    txtTotal.Text = total.ToString();
            }

            private void txtCal_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnAgregar_Click(object sender, EventArgs e)
             {
            dtgVenta.Rows.Add(txtCodigo.Text, txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);

            Double suma = 0;
            for (int i = 0; i<dtgVenta.Rows.Count; i++) {
                //String precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();
                String datosaoperartotal = dtgVenta.Rows[i].Cells[4].Value.ToString();

                Double datosConvertidos = Convert.ToDouble(datosaoperartotal);
               
                suma += datosConvertidos;

                txtTotalFinal.Text = suma.ToString();

                txtCodigo.Clear();
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Clear();
                txtTotal.Clear();

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                total = precio * cantidad;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex) {
            if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "0";
                    txtCantidad.SelectAll();
                }
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

