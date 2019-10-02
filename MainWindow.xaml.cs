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

        public float tong(float a, float b)
        {
            return (a + b);
        }

        public float hieu(float a, float b)
        {
            return (a - b);
        }

        public float tich(float a, float b)
        {
            return (a * b);
        }


        public float thuong(float a, float b)
        {
            return (a / b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            float a = float.Parse(txbNhapA.Text);
            float b = float.Parse(txbNhapB.Text);

            txbDapAn.Text = tong(a, b).ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(txbNhapA.Text);
            float b = float.Parse(txbNhapB.Text);

            txbDapAn.Text = hieu(a, b).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(txbNhapA.Text);
            float b = float.Parse(txbNhapB.Text);

            txbDapAn.Text = tich(a, b).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(txbNhapA.Text);
            float b = float.Parse(txbNhapB.Text);

            txbDapAn.Text = thuong(a, b).ToString();
        }
    }
}
