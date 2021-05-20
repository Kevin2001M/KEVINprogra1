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

            dataGridView1.Rows.Clear();

            foreach (var listardatos in clsProducto.CargarProducto(textBox1.Text)) {

                dataGridView1.Rows.Add(listardatos.idProducto, listardatos.nombreProducto, listardatos.precioProducto);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //FrmVenta frmventa = new FrmVenta();
            //frm

            FrmMenuVenta.frmVenta.txtCodigo.Text = id;
            FrmMenuVenta.frmVenta.txtNombre.Text = nombre;
            FrmMenuVenta.frmVenta.txtPrecio.Text = precio;
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
    }
}
