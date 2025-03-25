using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroGEMA
{
    internal class Usuario
    {
        public String nomUsuario { get; set; }
        public String contraseña { get; set; }
        public String correo { get; set; }
        public String fechaNac { get; set; }

        public Usuario() { }

        public Usuario(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
        }

        public Usuario(string nomUsuario, string contraseña, string correo) : this(nomUsuario)
        {
            this.contraseña = contraseña;
            this.correo = correo;
        }

        public Usuario(string nomUsuario, string correo, string fechaNac, string contraseña) : this(nomUsuario)
        {
            this.correo = correo;
            this.fechaNac = fechaNac;
            this.contraseña = contraseña;
        }

        public int altaUser(Usuario a)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = String.Format("insert into Usuario (nomUsuario, contraseña, correo, fechaNac) values('{0}', '{1}', '{2}', '{3}')", a.nomUsuario, a.contraseña, a.correo, a.fechaNac);
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public int eliminarUser(int nomUsuario)
        {
            int res = 0;
            SqlConnection con;
            SqlCommand cmd;
            con = Conexion.agregarConexion();
            String query = String.Format(("delete from Usuario where nomUsuario ='{0}'"), nomUsuario);
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int modificarUser(Usuario a)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = (String.Format("update User set contraseña= '{0}' where nomUsuario = '{1}' or correo='{2}' ", a.contraseña, a.nomUsuario, a.correo));
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public List<Usuario> buscarUser(String nombre)
        {
            Usuario a;
            List<Usuario> lis = new List<Usuario>();
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = String.Format("select * from Usuario where nombre like '%{0}%'", nomUsuario);
            cmd = new SqlCommand(query, con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                a = new Usuario();
                a.nomUsuario = rd.GetString(0);
                a.contraseña = rd.GetString(1);
                a.correo = rd.GetString(2);
                a.fechaNac = rd.GetString(3);
                lis.Add(a);

            }
            con.Close();
            rd.Close();
            return lis;
        }
    }
}
