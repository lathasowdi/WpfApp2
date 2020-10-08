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
    /// Interaction logic for Oefening4.xaml
    /// </summary>
    public partial class Oefening4 : Window
    {
        public Oefening4()
        {
            InitializeComponent();
             
        }
        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Leeftijd { get; set; }
            public string Adres { get; set; }
            //public string Geslacht { get; set; }
        }
        public Persoon persoon = new Persoon();
        public void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();
            info.Show();
            string voornaam = "";
            if (txtVoornaam.Text.Trim() != "")
            {
                voornaam= txtVoornaam.Text.Trim();
            }
            else
            {
                MessageBox.Show("Geef een voornaam a.u.b");
            }
            string achternaam = "";
            if (txtAchternaam.Text.Trim() != "")
            {
                achternaam = txtAchternaam.Text.Trim();
            }
            else
            {
                MessageBox.Show("Geef een achternaam a.u.b");
            }
           string Leeftijd = "";
            if (txtLeeftijd.Text.Trim() !="")
            {
                Leeftijd = txtLeeftijd.Text;
            }
            else
            {
                MessageBox.Show("Geef een Score a.u.b");
            }
            string adres = "";
            if (txtAdres.Text.Trim() != "")
            {
                adres =txtAdres.Text.Trim();
            }
            else
            {
                MessageBox.Show("Geef een achternaam a.u.b");
            }

            //string Geslacht = "";
            //if (rbFemale.IsChecked==true)
            //{
            //   Geslacht = rbFemale.;
            //}
            //else
            //{
            //    MessageBox.Show("Geef een Publicatie a.u.b");
            //}

            persoon.Voornaam = voornaam;
            persoon.Achternaam = achternaam;
            persoon.Leeftijd = Leeftijd;
            persoon.Adres = adres;
            
            MessageBox.Show("Persoon Toevoegd");
           
           
        }
    }
}
