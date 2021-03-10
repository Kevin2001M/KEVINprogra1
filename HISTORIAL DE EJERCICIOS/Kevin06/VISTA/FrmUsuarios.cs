using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kevin01.MODEL;

namespace Kevin01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
            clear();

        }

        void clear ()
        {

            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtYear.Clear();
            txtPass.Clear();


        }
        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities1 db = new programacionEntities1())
            {
                var Lista = db.UserList.ToList();

                foreach (var interacion in Lista)
                {
                    dtgListaUsuarios.Rows.Add(interacion.Id,interacion.NombreUsuario, interacion.Apellido,interacion.Edad,interacion.Pass);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            using (programacionEntities1 db = new programacionEntities1()) {
               
                UserList userList = new UserList();

                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtYear.Text);
                userList.Pass = txtPass.Text;
                db.UserList.Add(userList);
                db.SaveChanges();
                    MessageBox.Show("SAVE");
            }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
            clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities1 db = new programacionEntities1())
                {
                    int Eliminar = Convert.ToInt32(txtId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    //int Eliminar = Convert.ToInt32(txtId.Text);
                    //userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();
                    
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
            clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try { 
            using (programacionEntities1 db = new programacionEntities1())
            {
                int update = Convert.ToInt32(txtId.Text);
                UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtYear.Text);
                userList.Pass = txtPass.Text;
                db.SaveChanges();
                    //Otra forma de hacer lo mismo 
                    //UserList userList = new UserList();
                    //userList = db.UserList.Find(205);
                    //userList.NombreUsuario = "Jose";
                    
                }
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            Carga();
            clear();
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellidos = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            txtId.Text = Id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellidos;
            txtYear.Text = Edad;
            txtPass.Text = pass;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            clear();
        }
    }
}
