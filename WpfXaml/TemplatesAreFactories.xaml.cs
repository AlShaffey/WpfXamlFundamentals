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
    /// Interaction logic for TemplatesAreFactories.xaml
    /// </summary>
    public partial class TemplatesAreFactories : Window
    {
        public TemplatesAreFactories()
        {
            InitializeComponent();

            var controlTemplate = new ControlTemplate(typeof(Button));
            var factory = new FrameworkElementFactory(typeof(Ellipse));
            factory.SetValue(Shape.FillProperty, Brushes.Orange);
            controlTemplate.VisualTree = factory;
            btn.Template = controlTemplate;
        }
    }
}
