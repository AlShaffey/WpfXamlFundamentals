using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for WritingDataSources.xaml
    /// </summary>
    public partial class WritingDataSources : Window
    {
        Person m2 = new Person { Age = 33, Name = "m.2" };
        Person m0 = new Person { Age = 23, Name = "m.0" };
        Person m4 = new Person { Age = 43, Name = "m.4" };

        public int PersonId { get; set; } = 1;

        public ObservableCollection<Person> Persons { get; set; }

        public WritingDataSources()
        {
            InitializeComponent();

            Persons = new ObservableCollection<Person> { m2, m0, m4 };
            DataContext = Persons;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Persons.Add(new Person { Age = 0, Name = $"Person {PersonId++}" });
        }
    }
}
