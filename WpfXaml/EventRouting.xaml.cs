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
    /// Interaction logic for EventRouting.xaml
    /// </summary>
    public partial class EventRouting : Window
    {
        public EventRouting()
        {
            InitializeComponent();

            MouseEnter += EventRouting_MouseEnter;
            border.MouseEnter += EventRouting_MouseEnter;
            panel.MouseEnter += EventRouting_MouseEnter;
            ellipse.MouseEnter += EventRouting_MouseEnter;
            Rectangle.MouseEnter += EventRouting_MouseEnter;

            MouseDown += EventRouting_MouseDown;
            border.MouseDown += EventRouting_MouseDown;
            panel.MouseDown += EventRouting_MouseDown;
            ellipse.MouseDown += EventRouting_MouseDown;
            Rectangle.MouseDown += EventRouting_MouseDown;

            for (int i = 0; i < 5; i++)
            {
                var button = new Button { Content = "Button: " + i};
                panel.Children.Add(button);

                //button.Click += Button_Click;
            }

            panel.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.Source;
            button.Background = Brushes.Beige;
        }

        private void EventRouting_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("MouseDown: " + sender);
            e.Handled = true;
        }

        private void EventRouting_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("MouseEnter: " + sender);
        }
    }
}
