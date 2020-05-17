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
    /// Interaction logic for Question4.xaml
    /// </summary>
    public partial class Question5 : Window
    {
        int clickNumber;
        public Question5()
        {
            InitializeComponent();
            clickNumber = 0;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            clickNumber++;
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = clickNumber;
            if(clickNumber % 2 != 0)
            {
                oddNumber.Items.Add(treeViewItem);
            }
            else
            {
                evenNumber.Items.Add(treeViewItem);
            }

            if (btn.Background == Brushes.Red)
            {
                btn.Background = Brushes.Blue;
            }
            else
            {
                btn.Background = Brushes.Red;
            }

        }
    }
}
