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
    /// Interaction logic for Oefening6.xaml
    /// </summary>
    public partial class Oefening6 : Window
    {
        public Oefening6()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            int gewonnen = rng.Next(3);
            string input = txtNaam.Text.ToLower();
            switch(input)
            {
                case "blad":
                    if (gewonnen == 1)
                        MessageBox.Show("De computer koos Steen.Gewonnen!");
                    else if (gewonnen == 2)
                        MessageBox.Show("De Computer koos Schaar.Verloren!");
                    else
                        MessageBox.Show("De Computer Koos Blad.Gelijkspel");
                    break;
                case "steen":
                    if (gewonnen == 1)
                        MessageBox.Show("De Computer koos Schaar.Gewonnen!");
                    else if (gewonnen == 2)
                        MessageBox.Show("De Computer Koos Blad.Verloren!");
                    else
                        MessageBox.Show("De computer koos Steen.Gelijkspel");
                    break;
                case "schaar":
                    if (gewonnen == 1)
                        MessageBox.Show("De Computer Koos Blad. Gewonnen!");
                    else if (gewonnen == 2)
                        MessageBox.Show("De computer koos Steen. Verloren!");
                    else
                        MessageBox.Show("De Computer koos Schaar. Gelijkspel");
                    break;
            }
        }
    }
}
