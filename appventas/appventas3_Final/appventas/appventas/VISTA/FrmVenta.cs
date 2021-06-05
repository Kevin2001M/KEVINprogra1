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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            Calcular();

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
            calculartotal();

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

        void calculartotal()
        {
            Double suma = 0;
            for (int i = 0; i < dtgVenta.Rows.Count; i++)
            {
                //String precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();
                String datosaoperartotal = dtgVenta.Rows[i].Cells[4].Value.ToString();

                Double datosConvertidos = Convert.ToDouble(datosaoperartotal);

                suma += datosConvertidos;

                txtTotalFinal.Text = suma.ToString();
            }
        }

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCal_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)

        {
            Calcular();
            dtgVenta.Rows.Add(txtId.Text, txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);
            calculartotal();
            txtId.Text = "";
            txtNombre.Clear();
            txtPrecio.Text = "";
            txtCantidad.Clear();
            txtTotal.Clear();


            dtgVenta.Refresh();
            dtgVenta.ClearSelection();
            int ultimaFila = dtgVenta.Rows.Count - 1;
            dtgVenta.FirstDisplayedScrollingRowIndex = ultimaFila;
            dtgVenta.Rows[ultimaFila].Selected = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        void Calcular()
        {
            try
            {
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                total = precio * cantidad;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "1";
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                if (txtBuscar.Text.Equals(""))
                {
                    //if (e.KeyChar == 13)
                    //{
                    //e.Handled = true;
                    btnBuscar.PerformClick();
                    //    //txtCantidad.Focus();
                    //}
                }
                else
                {
                    e.Handled = true;
                    ClsDProducto prod = new ClsDProducto();
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(txtBuscar.Text));

                    if (busqueda.Count<1) {

                        MessageBox.Show("El codigo no existe");
                        txtBuscar.Text = "";
                    }

                    foreach (var iterar in busqueda)
                    {
                        txtId.Text = iterar.idProducto.ToString();
                        txtNombre.Text = iterar.nombreProducto;
                        txtPrecio.Text = iterar.precioProducto.ToString();
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        txtBuscar.Clear();
                    }
                }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btnBuscar.PerformClick();
                e.Handled = true;
                btnAgregar.PerformClick();
                txtBuscar.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
                ClsDVenta ventas = new ClsDVenta();
                tb_venta venta = new tb_venta();
                venta.iDDocumento = Convert.ToInt32(cbDocumento.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                venta.iDUsuario = 0;
                venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                ventas.save(venta);


                    ClsDDetalle detalle = new ClsDDetalle();
                    tb_detalleVenta tb_Detalle = new tb_detalleVenta();
                    foreach (DataGridViewRow dtgv in dtgVenta.Rows)
                    {
                        tb_Detalle.iDVenta = Convert.ToInt32(txtUltimaVenta);
                        tb_Detalle.iDProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                        tb_Detalle.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                        tb_Detalle.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                        tb_Detalle.total = Convert.ToDecimal(dtgv.Cells[5].Value.ToString());
                        detalle.guardardetalleventa(tb_Detalle);
                    }

                    ultimocorrelativodeventa();
                    dtgVenta.Rows.Clear();
                    txtTotalFinal.Text = "";
                    MessageBox.Show("Save");
            
        }catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        
    }

          

    private void dtgVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotal();
        }

        private void txtTotalFinal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

