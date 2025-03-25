using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroGEMA
{
    internal class Cita
    {
        public Int16 idCita { get; set; }
        public String estatus { get; set; }
        public String fecha { get; set; }
        public String tipo { get; set; }
        public Int16 precioFinal { get; set; }

        public Cita()
        {
        }

        public Cita(short idCita1)
        {
            idCita = idCita1;
        }

        public Cita(short idCita, string estatus, string fecha, string tipo, short precioFinal) : this(idCita)
        {
            this.estatus = estatus;
            this.fecha = fecha;
            this.tipo = tipo;
            this.precioFinal = precioFinal;
        }

        public int altaCita(Cita a)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = String.Format("insert into Cita (idCita, fecha, tipo, estatus, precioFinal) values({0}, '{1}', {2}, '{3}', {4})", a.idCita, a.fecha, a.tipo, a.estatus, a.precioFinal);
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public int eliminarCita(int idCita)
        {
            int res = 0;
            SqlConnection con;
            SqlCommand cmd;
            con = Conexion.agregarConexion();
            String query = String.Format(("delete from Cita where idCita ={0}"), idCita);
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public int modificarCita(Cita a)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = (String.Format("update Cita set fecha= '{0}' where idCita = {1} ", a.fecha, a.idCita));
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public List<Cita> buscarCita(String nombre)
        {
            Cita a;
            List<Cita> lis = new List<Cita>();
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmd;
            String query = String.Format("select * from Cita where idCita like '%{0}%'", idCita);
            cmd = new SqlCommand(query, con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                a = new Cita();
                a.idCita = rd.GetInt16(0);
                a.fecha = rd.GetString(1);
                a.tipo = rd.GetString(2);
                a.estatus = rd.GetString(3);
                a.precioFinal = rd.GetInt16(4);
                lis.Add(a);

            }
            con.Close();
            rd.Close();
            return lis;

        }

    }
}

