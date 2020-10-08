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
    /// Interaction logic for Oefening4.xaml
    /// </summary>
    public partial class Oefening4 : Window
    {
        
        public Oefening4()
        {
         
            InitializeComponent();
        }
        
      
        private void btnSubmit1_Click(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(txtValue1.Text);
            int value2 = Convert.ToInt32(txtValue2.Text);
            MessageBox.Show($"SOM VAN{txtValue1.Text} en {txtValue2.Text} is {value1 + value2}");
        }

        private void btnSubmit2_Click(object sender, RoutedEventArgs e)
        {

            int value1 = Convert.ToInt32(txtValue1.Text);
            int value2 = Convert.ToInt32(txtValue2.Text);
            MessageBox.Show($"MIN VAN{txtValue1.Text} en {txtValue2.Text} is {value1 - value2}");
        }

        private void btnSubmit3_Click(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(txtValue1.Text);
            int value2 = Convert.ToInt32(txtValue2.Text);
            MessageBox.Show($"MUL VAN{txtValue1.Text} en {txtValue2.Text} is {value1 * value2}");

        }

        private void btnSubmit4_Click(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(txtValue1.Text);
            int value2 = Convert.ToInt32(txtValue2.Text);
            MessageBox.Show($"DELEN VAN{txtValue1.Text} en {txtValue2.Text} is {value1/ value2}");
        }
    }
}
