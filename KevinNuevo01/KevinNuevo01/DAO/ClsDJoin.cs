using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KevinNuevo01.MODEL;

namespace KevinNuevo01.DAO
{
    class ClsDJoin
    {

        public List<List<Object>> JoinUsuarioType() {
            List<List<Object>> Matriz = new List<List<Object>>();
            using (PROGRAMACION1Entities db = new PROGRAMACION1Entities())
            {

                var Lista = (from usuario in db.UserList
                            from type in db.TypeOfUser
                            where usuario.IdTypeOfUser == type.IdTypeOfUser

                            select new
                            {
                                usuario.Id,
                                usuario.NombreUsuario,
                                type.IdTypeOfUser,
                                type.TypeOfUserName

                            }).ToList();


                for (int i = 0; i < Lista.Count; i++) {

                    Matriz.Add(new List<Object>()
                    {
                        Lista[i].Id, Lista[i].NombreUsuario, Lista[i].IdTypeOfUser, Lista[i].TypeOfUserName
                    });
                }


            }

                return Matriz;

        }
    }
}
