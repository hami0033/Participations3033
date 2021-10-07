using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace WPFPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PokemonAPI pokemon;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(@"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1118").Result;
                pokemon = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }
            cboPokemon.Items.Add("All");

            foreach (var poke in pokemon.Results)
            {
                cboPokemon.Items.Add(poke);
            }



        }
        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pokemon = (AllResults)cboPokemon.SelectedItem;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(pokemon.url).Result;
                pokemon = JsonConvert.DeserializeObject<SpecificAPI>(json);
            }

            txtWeight.Text = pokemon.weight;

            txtHeight.Text = pokemon.height;
        }

    }
}
