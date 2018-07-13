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
    /// Interaction logic for TextInput.xaml
    /// </summary>
    public partial class TextInput : Window
    {
        public TextInput()
        {
            InitializeComponent();

            // <TextBox SpellCheck.IsEnabled="True"/>
            // This is a special hack for Textbox only.
            //richTextBox.SpellCheck.IsEnabled = true;

            // This is how natuarally the ZAML synatax is interprested.
            SpellCheck.SetIsEnabled(richTextBox, true);
        }
    }
}
