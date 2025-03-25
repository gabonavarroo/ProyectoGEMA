using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistroGEMA
{
    /// <summary>
    /// Lógica de interacción para ModificarUsuario.xaml
    /// </summary>
    public partial class ModificarUsuario : Window
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbContra_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbModificar_Click(object sender, RoutedEventArgs e)
        {
            Usuario a = new Usuario(tbUsuario.Text, tbCorreo.Text, tbContra.Text);
            int res = a.modificarUser(a);
            if (res > 0)
                MessageBox.Show("el alumno se modificó");
            else
                MessageBox.Show("el alumno no se puedo modificar");
        }

        private void tbRegresar_Click(object sender, RoutedEventArgs e)
        {
            User w = new User();
            w.Show();
            this.Hide();
        }
    }
}
