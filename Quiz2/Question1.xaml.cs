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

namespace Quiz2
{
    /// <summary>
    /// Interaction logic for Question1.xaml
    /// </summary>
    public partial class Question1 : Window
    {
        public Question1()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
        }
        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName=txtLastName.Text;
            string phone = txtPhoneNumber.Text;
            MessageBox.Show($"FirstNmae:{firstName}, LastName:{lastName},Phone:{phone}");
        }
    }
}
