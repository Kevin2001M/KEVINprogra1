using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kevin01.DAO;
using Kevin01.DOMINIO;

namespace Kevin01.NEGOCIO
{
    class ClsLogin
    {
        public int Acceso(Login log)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            int estado = 0;
            for (int i = 0; i < cls.user.Length; i++)
            {
                if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i]))
                {
                    estado = 1;
                }
            }
            return estado;
        }

        public int accesoBidimecional(Login log)
        {
            string[][] usuarios;
            usuarios = new string[2][];
            usuarios[0] = new string[6] { "Kevin", "Mauricio", "Eduardo", "Karina", "Danilo", "Liseth"};
            usuarios[1] = new string[6] { "123", "1234", "124", "115", "001", "153"};

            usuarios = usuarios.Distinct().ToArray();

            int estado = 0;

            for (int i = 0; i < usuarios.Length; i++)
            {
                for (int j = 0; j < usuarios[i].Length; j++)
                {
                    if (log.Usuario.Equals(usuarios[i][j]) && log.Password.Equals(usuarios[i + 1][j]))
                    {
                        estado = 1;
                    }
                }
            }
            return estado;
        }
    }
}
