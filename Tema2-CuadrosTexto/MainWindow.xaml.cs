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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void NombretextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                if (nombreClienteLabel.Visibility == Visibility.Visible)
                    nombreClienteLabel.Visibility = Visibility.Hidden;
                else
                    nombreClienteLabel.Visibility = Visibility.Visible;
               
        }

        private void ApellidoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                if (apellidoClienteLabel.Visibility == Visibility.Visible)
                    apellidoClienteLabel.Visibility = Visibility.Hidden;
                else
                    apellidoClienteLabel.Visibility = Visibility.Visible;

        }

        private void EdadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                bool sonNumeros = true;
              
                char[] c = edadTextBox.Text.ToCharArray();

                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] < 48 || c[i] > 57)
                            sonNumeros = false;
                }

                switch (sonNumeros)
                {
                    case true :
                        edadIncorrectaLabel.Visibility = Visibility.Hidden;
                        break;
                    default:
                        edadIncorrectaLabel.Visibility = Visibility.Visible;
                        break;
                }

                
            }
        }
    }
}
