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

namespace WPFToys_Classes
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

        private void btnAddToy_Click(object sender, RoutedEventArgs e)
        {
            
            string manufacturer, name, price, image;

            manufacturer = txtManufacturer.Text;
            name = txtName.Text;
            price = txtPrice.Text;
            image = txtImage.Text;

            Toy newToy = new Toy(manufacturer, name, Convert.ToDouble(price), image);
            var uri = new Uri(image);
            var img = new BitmapImage(uri);


            if (string.IsNullOrEmpty(manufacturer))
            {
                MessageBox.Show("Please enter a manufacturer.");

                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");

                return;
            }

            if (double.TryParse(price))
            {
                MessageBox.Show("Please enter a valid price.");

                return;
            }

            if (string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Please enter an image URL.");

                return;
            }

            lstToys.Items.Add(new Toy());

        }

        private void lstToys_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());
        }
    }
}
