using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F26W5WpfControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetHobbies_Click(object sender, RoutedEventArgs e)
        {
            string hobbies = "";

            foreach (CheckBox chk in spHobbies.Children.OfType<CheckBox>())
            {
                if (chk.IsChecked == true)
                    hobbies += chk.Content + "\n";
            }

            lblOutput.Content = hobbies;
        }

        private void btnGetGender_Click(object sender, RoutedEventArgs e)
        {
            var selectedGender = spGender.Children.OfType<RadioButton>()
                                                  .FirstOrDefault(r => r.IsChecked == true);

            lblOutput.Content = selectedGender?.Content ?? "Select your gender";
        }

        private void btnGetCity_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = cmbCities.Text;
        }

        private void cmbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //lblOutput.Content = cmbCities.Text;
            lblOutput.Content = ((ComboBoxItem)cmbCities.SelectedItem).Content;
        }
    }
}