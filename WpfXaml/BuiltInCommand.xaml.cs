using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for BuiltInCommand.xaml
    /// </summary>
    public partial class BuiltInCommand : Window
    {
        public BuiltInCommand()
        {
            InitializeComponent();

            var copyCommandBinding = new CommandBinding(ApplicationCommands.Copy);

            CommandBindings.Add(copyCommandBinding);

            copyCommandBinding.Executed += CopyCommandBinding_Executed;

            copyCommandBinding.CanExecute += CopyCommandBinding_CanExecute;
        }

        private void CopyCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void CopyCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy executed");
        }
    }
}
