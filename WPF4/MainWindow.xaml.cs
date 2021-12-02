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

namespace WPF4
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
            res0.Text = Convertsum(rate0, sum0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            res1.Text = Convertsum(rate1, sum1);
        }

        private string Convertsum(TextBox ratebox, TextBox sum)
        {
            {
                return (Convert.ToDouble(ratebox.Text) * Convert.ToDouble(sum.Text)).ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            res2.Text = Convertsum(rate2, sum2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            res3.Text = Convertsum(rate3, sum3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {             
            inch_m.Text = (Convert.ToDouble(inch.Text) * 2.54).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ft_m.Text = (Convert.ToDouble(ft.Text) * 0.3048).ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ml_m.Text = (Convert.ToDouble(ml.Text) * 1609).ToString();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            km_m.Text = (Convert.ToDouble(km.Text) * 1000).ToString();

        }
    }
    }
