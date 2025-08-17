using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Эта строка должна быть обязательно!
        }

        private void OnOperationClick(object sender, RoutedEventArgs e)
        {
            // Проверяем, что элементы существуют
            if (txtA == null || txtB == null || txtResult == null)
            {
                MessageBox.Show("Ошибка инициализации элементов интерфейса");
                return;
            }

            if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
            {
                txtResult.Text = "Ошибка ввода";
                return;
            }

            string operation = (sender as Button)?.Content?.ToString() ?? "";
            double result = 0;

            switch (operation)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/": result = b != 0 ? a / b : double.NaN; break;
            }

            txtResult.Text = result.ToString();
        }
    }
}