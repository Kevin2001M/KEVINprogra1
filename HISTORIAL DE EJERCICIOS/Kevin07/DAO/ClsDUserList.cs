using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kevin01.MODEL;

namespace Kevin01.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargaDatoLit() {
            List<UserList> Lista;

            using (programacionEntities1 db = new programacionEntities1())
            {
                Lista = db.UserList.ToList();

                
            }

            return Lista;
        }
        //public void SaveDatoUser(String Nombre, String Apellidos, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (programacionEntities1 db = new programacionEntities1())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsuario = Nombre;
        //            userList.Apellido = Apellidos;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();
        //            MessageBox.Show("SAVE");
        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(EX.ToString());
        //    }
        //} 

        public void SaveDatoUser(UserList user)
        {
            try
            {
                using (programacionEntities1 db = new programacionEntities1())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
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

        public void deleteUser(int iD)
        {
            try
            {
                using (programacionEntities1 db = new programacionEntities1())
                {
                    int Eliminar = Convert.ToInt32(iD);
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
        }
        public void update(UserList user)
        {
            try
            {
                using (programacionEntities1 db = new programacionEntities1())
                {
                    int update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();
                    //Otra forma de hacer lo mismo 
                    //UserList userList = new UserList();
                    //userList = db.UserList.Find(205);
                    //userList.NombreUsuario = "Jose";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
