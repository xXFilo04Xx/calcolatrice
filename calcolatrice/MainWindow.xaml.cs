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

namespace calcolatrice
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtnumero.Text);
            double n = n1 -1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double n2 = double.Parse(txtnumero.Text);
            double n = n2 - 0.1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double n3 = double.Parse(txtnumero.Text);
            double n = n3 - 0.01;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double n4 = double.Parse(txtnumero.Text);
            double n = n4 * 0.01;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double n5 = double.Parse(txtnumero.Text);
            double n = n5 * 0.001;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double n6 = double.Parse(txtnumero.Text);
            double n = n6 * 0.1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double n7 = double.Parse(txtnumero.Text);
            double n = n7 + 1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double n8 = double.Parse(txtnumero.Text);
            double n = n8 + 0.1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double n8 = double.Parse(txtnumero.Text);
            double n = n8 + 0.01;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            double n9 = double.Parse(txtnumero.Text);
            double n = n9 / 0.1;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            double n10 = double.Parse(txtnumero.Text);
            double n = n10 / 0.01;
            txtnumero.Text = n.ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            double n11 = double.Parse(txtnumero.Text);
            double n = n11 / 0.001;
            txtnumero.Text = n.ToString();
        }
    }
}
