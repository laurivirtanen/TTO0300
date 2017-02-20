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

namespace DataBindingDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBindingDemo2.ViewModel.StudentViewModel svmo = new ViewModel.StudentViewModel();

        public MainWindow()
        {
            InitializeComponent();
            svmo.LoadStudents();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewControl.DataContext = svmo;
        }

        private void dtgStudents_Loaded(object sender, RoutedEventArgs e)
        {
            dtgStudents.DataContext = svmo.Students;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //luodaan observablecollectioniin uusi Student -olio
            DataBindingDemo2.Model.Student uusi = new Model.Student();
            uusi.FirstName = txtFirstname.Text;
            uusi.LastName = txtLastName.Text;
            svmo.Students.Add(uusi);
            txtFirstname.Text = ""; txtLastName.Text = "";
        }
    }
}
