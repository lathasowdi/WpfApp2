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
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            Oefening4 oefening4 = new Oefening4();
            if (oefening4.persoon.Voornaam != "")
            {
                txtVoornaam.Text = oefening4.persoon.Voornaam;
            }
            if (oefening4.persoon.Achternaam != "")
            {
                txtAchternaam.Text = oefening4.persoon.Achternaam;
            }
            if (oefening4.persoon.Leeftijd != "")
            {
                txtLeeftijd.Text = oefening4.persoon.Leeftijd;
            }
            if (oefening4.persoon.Adres != "")
            {
                txtAdres.Text = oefening4.persoon.Adres;
            }
            //if (oefening4.rbFemale.IsChecked == true&& oefening4.rbFemale!="")
            //    txtGeslacht.Text = "VROUW";
            //else
            //    txtGeslacht.Text = "MAN";


            InitializeComponent();
        }

        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
