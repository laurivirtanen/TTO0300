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

namespace DataBindingTeht3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Tyontekija> Workers = new List<Tyontekija>();
        int workerId = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeThings();

        }


        public void InitializeThings()
        {
            Workers.Add(new Tyontekija("Lasse", "Mortensen", workerId+=1, 3414, "Opiskelija"));
            Workers.Add(new Tyontekija("Lasse", "Mortensen", workerId+=1, 3414, ""));
            Workers.Add(new Tyontekija("Lasse", "Mortensen", workerId+=1, 3414, ""));
            Workers.Add(new Tyontekija("Lasse", "Mortensen", workerId+=1, 3414, ""));
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lsb1.Content = Workers[0].ToString();
            lsb2.Content = Workers[1].ToString();
            lsb3.Content = Workers[2].ToString();
            lsb4.Content = Workers[3].ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lsbLeftBox.Items.Clear();
            spMid.DataContext = null;
        }


        private void lsbLeftBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lsbLeftBox.SelectedValue != null)
                spMid.DataContext = Workers[lsbLeftBox.SelectedIndex];
        }
    }
}
