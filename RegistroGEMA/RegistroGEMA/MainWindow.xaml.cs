﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistroGEMA;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void txUsuario_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txPassword_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Opcion w = new Opcion();
        w.Show();
        this.Hide();
    }
}