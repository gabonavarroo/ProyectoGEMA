using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    /// Lógica de interacción para Opcion.xaml
    /// </summary>
    public partial class Opcion : Window
    {
        public Opcion()
        {
            InitializeComponent();
        }

        private void btCita_Click(object sender, RoutedEventArgs e)
        {
            AltaCita w = new AltaCita();
            w.Show();
            this.Hide();
        }

        private void btDoctor_Click(object sender, RoutedEventArgs e)
        {
            /*Doctor w = new Doctor();
            w.Show();
            this.Hide();*/
        }

        private void btUser_Click(object sender, RoutedEventArgs e)
        {
            User w = new User();
            w.Show();
            this.Hide();
        }
    }
}
