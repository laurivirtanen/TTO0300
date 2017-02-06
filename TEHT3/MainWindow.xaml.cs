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

namespace TEHT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        private int kpuu = 45;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            float leveys;
            float korkeus;

            float.TryParse(textBox1.Text, out korkeus);

            if (float.TryParse(textBox.Text, out leveys))
            {
                
                textBox4.Text = (leveys * korkeus).ToString("F00") + " cm^2";
            }
        }
    }
}
