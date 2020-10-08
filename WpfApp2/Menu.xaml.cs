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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void btnSubmit2_Click(object sender, RoutedEventArgs e)
        {
            Oefening3 oefening3 = new Oefening3();
            oefening3.Show();
        }

        private void btnSubmit3_Click(object sender, RoutedEventArgs e)
        {
            Oefening4 oefening4 = new Oefening4();
            oefening4.Show();
        }

        private void btnSubmit4_Click(object sender, RoutedEventArgs e)
        {
            Oefening5 oefening5 = new Oefening5();
            oefening5.Show();
        }

        private void btnSubmit5_Click(object sender, RoutedEventArgs e)
        {
            Oefening6 oefening6 = new Oefening6();
            oefening6.Show();
        }
    }
}
