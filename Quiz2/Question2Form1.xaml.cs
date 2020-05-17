using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public delegate void delPassDate(string date);

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //using delegate
            _2_ShowCalandar frm = new _2_ShowCalandar();
            delPassDate delPassDate = new delPassDate(frm.passData);
            delPassDate(this.cldSample.SelectedDate.ToString());
            frm.Show();

        }
        public string _date
        {
            get { return cldSample.SelectedDate.ToString(); }
        }
    }
}
