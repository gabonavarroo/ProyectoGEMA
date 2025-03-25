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
    /// Lógica de interacción para AltaCita.xaml
    /// </summary>
    public partial class AltaCita : Window
    {
        public AltaCita()
        {
            InitializeComponent();
        }

        private void agregarBt_Click(object sender, RoutedEventArgs e)
        {
            /*int res;
            Cita a = new Cita(Int16.Parse(fechaTb_TextChanged.Text),tipoTb_TextChanged.Text, Int16.Parse(precioTb.Text)
            res = a.altaCita(a);
            if (res > 0)
               MessageBox.Show("la cita se ha dado de alta");
            else
               MessageBox.Show("la cita no se puedo dar de alta");*/
        }

        private void eliminarBt_Click(object sender, RoutedEventArgs e)
        {
            /*eliminarCita w = new eliminarCita();
            w.Show();
            this.Hide();*/
        }

        private void buscarBt_Click(object sender, RoutedEventArgs e)
        {
            /*Cita a = new Cita();
            dgDatos.ItemsSource = a.buscarCita(nombreTb.Text);*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Opcion w = new Opcion();
            w.Show();
            this.Hide();
        }

        private void nombreTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tipoTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void fechaTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void precioTB(object sender, TextChangedEventArgs e)
        {

        }
    }
}
