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

namespace WpfApplication1
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

        private void Button_Click_tong(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }             

       private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txtgt1.Text);
            b = float.Parse(txtgt2.Text);
            c = a * b;
            txtkq.Text = string.Format("{0:0.0}", c);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txtgt1.Text);
            b = float.Parse(txtgt2.Text);
            c = a + b;
            txtkq.Text = string.Format("{0:0.0}", c);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txtgt1.Text);
            b = float.Parse(txtgt2.Text);
            c = a - b;
            txtkq.Text = string.Format("{0:0.0}", c);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txtgt1.Text);
            b = float.Parse(txtgt2.Text);
            if (b == 0)
            {
                MessageBox.Show("KHONG CHIA DUOC");
            }
            else
            {
                c = a / b;
                txtkq.Text = string.Format("{0:0.0}", c);
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
