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

namespace Proyecto_Final_Calculadora_Reg.Pantallas
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, RoutedEventArgs e)
        {
            var calculadoraWindow = new Proyecto_Final_Calculadora_Reg.Pantallas.Calculadora();
            calculadoraWindow.Show();
            this.Close(); // Cierra la ventana actual
        }

        private void ValidadorRegex_Click(object sender, RoutedEventArgs e)
        {            
            var validadorRegexWindow = new Proyecto_Final_Calculadora_Reg.Pantallas.VerificacionRegex();
            validadorRegexWindow.Show();
            this.Close(); // Cierra la ventana actual
        }
    }
}
