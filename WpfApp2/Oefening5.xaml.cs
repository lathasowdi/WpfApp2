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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Oefening5.xaml
    /// </summary>
    public partial class Oefening5 : Window
    {
        public List<Persoon> personLijst = new List<Persoon>();
        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }


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
        public Oefening5()
        {
            InitializeComponent();
            cbPersonen.ItemsSource = personLijst;
            personLijst.Add(new Persoon() { Voornaam = "Bhavana", Achternaam = "Saravanakumar" } );
            personLijst.Add(new Persoon() { Voornaam = "Vasuki", Achternaam = "Sowdi" });
            personLijst.Add(new Persoon() { Voornaam = "Latha", Achternaam = "Sowdi" });
        }
        
      

        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            string voornaam = txtValue1.Text;
            string achternaam = txtValue2.Text;
            personLijst.Add(new Persoon(){ Voornaam = voornaam, Achternaam = achternaam });
            cbPersonen.ItemsSource = personLijst;
        }
    }
}
