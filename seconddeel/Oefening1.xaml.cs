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

namespace seconddeel
{
    /// <summary>
    /// Interaction logic for Oefening1.xaml
    /// </summary>
    public partial class Oefening1 : Window
    {
        public List<Persoon> personLijst = new List<Persoon>();
        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Afbeelding { get; set; }


            //public Persoon(string voornaam, string achternaam)
            //{
            //    Voornaam = voornaam;
            //    Achternaam = achternaam;
            //}
            //public string FullName
            //{
            //    get
            //    {
            //        return $"{ Voornaam} {Achternaam}";
            //    }
            //}
        }
      

        public Oefening1()
        {
            InitializeComponent();
            cbPersonen.ItemsSource = personLijst;
            personLijst.Add(new Persoon() { Voornaam = "Bhavana", Achternaam = "Saravanakumar", Afbeelding = @"C:\Users\Latha\source\repos\WPF\WpfApp2\Bhavana.jpg" });
            personLijst.Add(new Persoon() { Voornaam = "Atchaya", Achternaam = "Saravanakumar",Afbeelding = @"C:\Users\Latha\source\repos\WPF\WpfApp2\Atchaya.jpg" });
            personLijst.Add(new Persoon() { Voornaam = "Latha", Achternaam = "Sowdi", Afbeelding = @"C:\Users\Latha\source\repos\WPF\WpfApp2\Latha.jpg" });
            personLijst.Add(new Persoon() { Voornaam = "Saravanakumar", Achternaam = "Bala", Afbeelding = @"C:\Users\Latha\source\repos\WPF\WpfApp2\Saravana.jpg" });
        }

        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persoon selected = (Persoon)cbPersonen.SelectedItem;
            imgCombobox.DataContext = selected;
        }
    }
}
