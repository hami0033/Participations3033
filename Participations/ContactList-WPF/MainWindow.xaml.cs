using System;
using System.Collections.Generic;
using System.IO;
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

namespace ContactList_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contacts> ContactList = new List<Contacts>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("contacts.txt").Skip(1);

            foreach (var line in lines)
            {
                ContactList.Add(new Contacts(line));
            }

            PopulateListBox(ContactList);
        }

        private void PopulateListBox(List<Contacts> contactList)
        {
            foreach (var show in ContactList)
            {
                lstContacts.Items.Add(contact);
            }
        }

        private void btnShowDetails_Click(object sender, RoutedEventArgs e)
        {

            var uri = new Uri("");
            var img = new BitmapImage(uri);
        }
    }
}
