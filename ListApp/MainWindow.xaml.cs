using System.Windows;

namespace ListApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Критически важная строка
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput != null && lstItems != null) // Проверка на null
            {
                if (!string.IsNullOrWhiteSpace(txtInput.Text))
                {
                    lstItems.Items.Add(txtInput.Text);
                    txtInput.Clear();
                }
            }
        }
    }
}