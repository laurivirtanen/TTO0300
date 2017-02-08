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

namespace TTO0300
{
    /// <summary>
    /// Interaction logic for sup.xaml
    /// </summary>
    public partial class sup : Window
    {
        int cnt;
        public sup()
        {
            InitializeComponent();
            cnt = 0;
            txtCounter.Text = cnt.ToString();
        }

        private void btnHi_Click(object sender, RoutedEventArgs e)
        {
            txtMessages.Text = "Hello " + txtName.Text;
            cnt++;
            txtCounter.Text = cnt.ToString();
            txtMessages.Text = "Nappi";
        }
    }
}
