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

namespace TEHT_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    
    public partial class MainWindow : Window
    {
        private double input = 0;
        public MainWindow()
        {
            try { 
            InitializeComponent();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(txtInput.Text.ToString(), out input))
            {
                if ((rdbHumi.IsChecked == true) && (input <= 100f))
                {
                    txtHumi.Text = txtInput.Text.ToString();
                }
                else if (rdbTemp.IsChecked == true && input <= 120f)
                {
                    txtTemp.Text = txtInput.Text.ToString();
                }
            }


        }
        private void btn1(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "1";
        }
        private void btn2(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "2";
        }
        private void btn3(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "3";
        }
        private void btn4(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "4";
        }
        private void btn5(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "5";
        }
        private void btn6(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "6";
        }
        private void btn7(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "7";
        }
        private void btn8(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "8";
        }
        private void btn9(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "9";
        }
        private void btn0(object sender, RoutedEventArgs e)
        {
            txtInput.Text += "0";
        }
        private void btnEf(object sender, RoutedEventArgs e)
        {
            txtInput.Text += ".";
        }
        private void btnCan(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text.Length > 0) { txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1); }
            
        }




    }
}
