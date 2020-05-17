using System;
using System.Collections;
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
    public partial class Question4 : Window
    {
       
            ArrayList studentList = new ArrayList();
        public Question4()
        {
            InitializeComponent();
            studentList.Add(new Student(1, "One"));
            studentList.Add(new Student(2, "Two"));
            studentList.Add(new Student(3, "Three"));
            studentList.Add(new Student(4, "Four"));
            studentList.Add(new Student(5, "Five"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            int.TryParse(txtBox.Text, out i);
            if (i>5 || i <1)
            {
                MessageBox.Show("user is not in the list");

            }
            if (txtBox.Text == "")
            {
                MessageBox.Show("ID must be inputed!");
            }
            else
            {
                foreach(Student stu in studentList)
                {
                    if ((stu.ID.ToString() == txtBox.Text))
                    {
                        if (!lstBox.Items.Contains(stu.Name))
                            lstBox.Items.Add(stu.Name);
                        else
                            MessageBox.Show("This student already exists!");
                    }
                }
            }
        }
    }
}
