using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RegistroGEMA
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=LAPTOPGABO\\TEW_SQLEXPRESS; Initial Catalog=dbAlumno1; Integrated Security=True; Encrypt=False");
                cnn.Open();
                //MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("No se pudo conectar" + ex);
            }
            return cnn;
        }

        public static void llenarCombo(ComboBox cb)
        {
            try
            {
                SqlDataReader rd;
                SqlConnection con;
                SqlCommand cmd;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nombre from programa", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //cb.Items.Add(rd["nombre"].ToString());
                    cb.Items.Add(rd.GetString(0));
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }
        }
    }
}
