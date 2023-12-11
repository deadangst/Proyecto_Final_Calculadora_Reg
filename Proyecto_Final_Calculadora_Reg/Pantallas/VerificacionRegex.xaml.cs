using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Proyecto_Final_Calculadora_Reg.Pantallas
{
    public partial class VerificacionRegex : Window
    {
        public VerificacionRegex()
        {
            InitializeComponent();
            // Habilita el botón de validar cuando hay texto en el cuadro de entrada
            InputBox.TextChanged += (s, e) => BtnValidar.IsEnabled = !string.IsNullOrWhiteSpace(InputBox.Text);
        }

        // Evento de clic para el botón de validación
        private void Validar_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si se ha seleccionado alguna opción de expresión regular
            if (!RegexOptionSelected())
            {
                MessageBox.Show("Selecciona una de las opciones de Expresión Regular para validar");
                return;
            }

            // Obtiene el patrón de expresión regular basado en la opción seleccionada
            string regexPattern = GetRegexPattern();
            // Verifica si el texto ingresado coincide con el patrón de expresión regular
            bool isValid = Regex.IsMatch(InputBox.Text, regexPattern);
            MessageBox.Show(isValid ? "Expresión regular Válida" : "Expresión regular no válida");
        }

        // Comprueba si alguna opción de expresión regular está seleccionada
        private bool RegexOptionSelected()
        {
            return RadioButtonCorreo.IsChecked == true ||
                   RadioButtonFecha.IsChecked == true ||
                   RadioButtonIdentificacion.IsChecked == true;
        }

        // Devuelve el patrón de expresión regular basado en la opción seleccionada
        private string GetRegexPattern()
        {
            if (RadioButtonCorreo.IsChecked == true)
                return @"^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            if (RadioButtonFecha.IsChecked == true)
                return @"^\d{2}\/\d{2}\/\d{4}$";
            if (RadioButtonIdentificacion.IsChecked == true)
                return @"^(?:[1-9]-\d{4}-\d{4}|0[1-9]-\d{4}-\d{4}|\d{9}|0\d{9})$";

            throw new InvalidOperationException("Ninguna opción de expresión regular está seleccionada.");
        }

        // Evento de clic para volver al menú principal
        private void MenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            var mainMenuWindow = new Proyecto_Final_Calculadora_Reg.Pantallas.MainMenu();
            mainMenuWindow.Show();
            this.Close(); // Cierra la ventana actual
        }
    }
}

