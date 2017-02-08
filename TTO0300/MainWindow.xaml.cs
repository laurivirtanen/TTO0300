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

namespace TTO0300
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

        private void OnClick(object sender, RoutedEventArgs e)
        {
            try
            { 
            int j;
            
            if (Int32.TryParse(textBlock.Text, out j)) { j++;  }
            textBlock.Text = j.ToString();

            }catch(Exception ex)
            {

               MessageBox.Show("Error",ex.Message);
            }
        }

        private void OnClick2(object sender, RoutedEventArgs e)
        {
            try
            {
                int j;
                if (Int32.TryParse(textCars.Text, out j)) { j++; }
                textCars.Text = j.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            
            
            sup supp = new TTO0300.sup();
            supp.ShowDialog();
        }
    }
}
