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

namespace WpfXaml
{
    /// <summary>
    /// Interaction logic for WithDataContext.xaml
    /// </summary>
    public partial class WithDataContext : Window
    {
        Person person = new Person { Age = 33, Name = "m.2" };
        public WithDataContext()
        {
            InitializeComponent();

            DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var personWithAge = person.Name + " is " + person.Age;
            MessageBox.Show(personWithAge);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            person.Age += 1;
            textBoxAge.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            person.Name += 1;
        }
    }
}
