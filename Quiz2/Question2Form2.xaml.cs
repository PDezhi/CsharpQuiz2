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
    /// Interaction logic for _2_ShowCalandar.xaml
    /// </summary>
    public partial class _2_ShowCalandar : Window
    {
        public _2_ShowCalandar()
        {
            InitializeComponent();
        }

        public void passData(string date)
        {
            lblValue.Content = date;
        }
        public string _textBox
        {
            set { lblValue.Content = value; }
        }
    }
}
