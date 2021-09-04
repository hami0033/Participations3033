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

namespace WpfApp1
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string name, age;

            name = txtName.Text;
            age = txtBirthday.Text;

            DateTime BirthdayAsDate = Convert.ToDateTime(age);
            var howOld = DateTime.Now - BirthdayAsDate;
            double ageNumber = Convert.ToDouble(howOld.TotalDays / 365);

            string ageNbrString = ageNumber.ToString("N2");

            MessageBox.Show($"{name} is {ageNbrString} years old.");

        }

        private void btnCalculate_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCalculate.Background = new SolidColorBrush(Colors.DarkBlue);
        }

        private void btnCalculate_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCalculate.Background = new SolidColorBrush(Colors.LightSeaGreen);
        }
    }
}
