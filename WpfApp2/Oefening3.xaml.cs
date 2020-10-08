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
    /// Interaction logic for Oefening3.xaml
    /// </summary>
    public partial class Oefening3 : Window
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
           int value1 = Convert.ToInt32(txtValue1.Text);
            int value2= Convert.ToInt32(txtValue2.Text);
    MessageBox.Show($"SOM VAN{txtValue1.Text} en {txtValue2.Text} is {value1+value2}");
        }
    }
}
