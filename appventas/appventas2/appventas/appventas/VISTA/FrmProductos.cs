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

namespace appventas.VISTA
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            cargardatos();
        }

        void cargardatos()
        {
            ClsDProducto clsProducto = new ClsDProducto();

            dtgProducto.Rows.Clear();

            foreach (var listardatos in clsProducto.CargarProducto(textBox1.Text)) {

                dtgProducto.Rows.Add(listardatos.idProducto, listardatos.nombreProducto, listardatos.precioProducto);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void envio()
        {
            String id = dtgProducto.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtgProducto.CurrentRow.Cells[1].Value.ToString();
            String precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();

            //FrmVenta frmventa = new FrmVenta();
            //frm

            FrmMenuVenta.frmVenta.txtCodigo.Text = id;
            FrmMenuVenta.frmVenta.txtNombre.Text = nombre;
            FrmMenuVenta.frmVenta.txtPrecio.Text = precio;
            FrmMenuVenta.frmVenta.txtCantidad.Focus();
            this.Close();
        }

        private void FrmProductos_TextChanged(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtgProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        private void dtgProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                envio();
            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
