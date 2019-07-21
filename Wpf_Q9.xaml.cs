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

namespace HW1707_Wpf_Q8
{
    /// <summary>
    /// Interaction logic for Wpf_Q9.xaml
    /// </summary>
    public partial class Wpf_Q9 : Window
    {
        public List<Country> countries = new List<Country>();

        public Wpf_Q9()
        {
            InitializeComponent();
            countries.Add(new Country { CountryName = "Israel", CapitalCityName = "Jerusalem", FlagName = "Resources/MagenDavid.png" });
            countries.Add(new Country { CountryName = "USA", CapitalCityName = "Washngton DC", FlagName = "Resources/fiftyStars.png" });
            countries.Add(new Country { CountryName = "Egypt", CapitalCityName = "Kahir", FlagName = "Resources/BlackBirdRed.png" });

            myComboBox.ItemsSource = countries;
            myComboBox.SelectedIndex = 0;
        }

        public class Country
        {
            public string CountryName { get; set; }
            public string CapitalCityName { get; set; }
            public string FlagName { get; set; }

            public override string ToString()
            {
                return $"{CountryName} {CapitalCityName}";
            }
        }
        }
}
