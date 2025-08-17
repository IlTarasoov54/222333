using System.Windows;
using System.Windows.Controls;

namespace PlanetsApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlanetSelected(object sender, SelectionChangedEventArgs e)
        {
            if (PlanetsListBox.SelectedItem == null) return;

            string selectedPlanet = ((ListBoxItem)PlanetsListBox.SelectedItem).Content.ToString();

            string info = GetPlanetInfo(selectedPlanet);

            PlanetInfoTextBox.Text = info;
        }

        private string GetPlanetInfo(string planetName)
        {
            return planetName switch
            {
                "Меркурий" => "Меркурий - ближайшая к Солнцу планета.\nДиаметр: 4 880 км\nПериод обращения: 88 дней\nТемпература: от -180°C до +430°C",
                "Венера" => "Венера - вторая планета от Солнца.\nДиаметр: 12 104 км\nПериод обращения: 225 дней\nТемпература: ~470°C (самая горячая планета)",
                "Земля" => "Земля - третья планета от Солнца.\nДиаметр: 12 742 км\nПериод обращения: 365 дней\nЕдинственная известная планета с жизнью",
                "Марс" => "Марс - четвертая планета от Солнца.\nДиаметр: 6 779 км\nПериод обращения: 687 дней\nИзвестен как 'Красная планета'",
                "Юпитер" => "Юпитер - крупнейшая планета системы.\nДиаметр: 139 820 км\nПериод обращения: 12 лет\nИмеет 79 известных спутников",
                "Сатурн" => "Сатурн - шестая планета от Солнца.\nДиаметр: 116 460 км\nПериод обращения: 29 лет\nИзвестен своими кольцами",
                "Уран" => "Уран - седьмая планета от Солнца.\nДиаметр: 50 724 км\nПериод обращения: 84 года\nОсь вращения наклонена на 98°",
                "Нептун" => "Нептун - восьмая планета от Солнца.\nДиаметр: 49 244 км\nПериод обращения: 165 лет\nСамый ветреный мир в системе",
                _ => "Информация о выбранной планете отсутствует"
            };
        }
    }
}