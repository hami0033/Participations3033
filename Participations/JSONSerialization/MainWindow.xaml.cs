using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace JSONSerialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Games> Game = new List<Games>();
        public MainWindow()
        {
            InitializeComponent();

            cboPlatform.SelectedIndex = 0;
            
            var lines = File.ReadAllLines("all_games.csv").Skip(1);

            foreach (var line in lines)
            {
                Game.Add(new Game(line));
            }

            PopulateComboBox(Game);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] pieces = lines[i].Split(',');

                Games g = new Games(pieces[0], pieces[1], pieces[2], pieces[3], pieces[4], pieces[5]);
                lstGames.Items.Add(g);
            }

            platforms = JsonConvert.SerializeObject<string[]>(json);
            
            cboPlatform.Items.Add("All");
        }

        private void PopulateComboBox(List<Games> game)
        {
            foreach (var platform in Games)
            {
                cboPlatform.Items.Add(platform);
            }
        }
    }
}
