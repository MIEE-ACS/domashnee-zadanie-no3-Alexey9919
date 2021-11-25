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

namespace Zagrebin_Dz3
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

        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            string str;
            str = tbA.Text;
            char[] sReverse = str.ToCharArray();
            Array.Reverse(sReverse);
            str = new string(sReverse);

            var words = str.Split(new[] {  '.', ' ', ';', ':', '?' }, StringSplitOptions.RemoveEmptyEntries);
            tbB.Text=(string.Join(" ", words.Reverse()));


            
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
