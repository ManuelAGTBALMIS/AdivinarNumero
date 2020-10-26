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

namespace AdivinarNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random general = new Random();
        int numeroRandom;

        public MainWindow()
        {
            numeroRandom = general.Next(0, 101);

            InitializeComponent();
        }


        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {

                if (int.Parse(NumeroTextBox.Text) > numeroRandom)
                {
                    ResultadoTextBlock.Text = "Te has pasado";
                }
                else if (int.Parse(NumeroTextBox.Text) < numeroRandom)
                {
                    ResultadoTextBlock.Text = "Te has quedado corto";
                }
                else
                {
                    ResultadoTextBlock.Text = "¡Has acertado!";
                }
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            NumeroAleatorio();
            ResultadoTextBlock.Text = "";
            NumeroTextBox.Text = "";
        }

        private int NumeroAleatorio()
        {
            numeroRandom = general.Next(0, 101);
            return numeroRandom;
        }

    }
}
