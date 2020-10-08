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

namespace seconddeel
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

        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            Oefening1 oefening1 = new Oefening1();
            oefening1.Show();
        }

        private void btnSubmit2_Click(object sender, RoutedEventArgs e)
        {
            Oefening2 oefening2 = new Oefening2();
            oefening2.Show();
        }

        private void btnSubmit3_Click(object sender, RoutedEventArgs e)
        {
            Oefening3 oefening3 = new Oefening3();
            oefening3.Show();
        }

        private void btnSubmit4_Click(object sender, RoutedEventArgs e)
        {
            Oefening4 oefening4 = new Oefening4();
            oefening4.Show();
        }
    }
}
