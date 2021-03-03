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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities1 db = new programacionEntities1())
                {
                    UserList userList = new UserList();
                    int Eliminar = Convert.ToInt32(txtId.Text);
                    userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();
                    
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
    }
}
