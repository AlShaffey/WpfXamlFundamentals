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

namespace WpfXaml
{
    /// <summary>
    /// Interaction logic for Validation.xaml
    /// </summary>
    public partial class Validation : Window
    {
        Person m2 = new Person { Age = 33, Name = "m.2" };
        Person m0 = new Person { Age = 23, Name = "m.0" };
        Person m4 = new Person { Age = 43, Name = "m.4" };
        public Validation()
        {
            InitializeComponent();

            DataContext = new List<Person> { m2, m0, m4 };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var personWithAge = m2.Name + " is " + m2.Age;
            MessageBox.Show(personWithAge);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            m2.Age += 1;
            //textBoxAge.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }
    }
}
