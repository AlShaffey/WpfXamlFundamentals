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
    /// Interaction logic for ResourceReferences.xaml
    /// </summary>
    public partial class ResourceReferences : Window
    {
        private static readonly string BrushResource = "brushResource";

        public ResourceReferences()
        {
            InitializeComponent();

            StaticRectangle.Fill = (Brush)FindResource(BrushResource);

            DynamicRectangle.SetResourceReference(Rectangle.FillProperty, BrushResource);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources[BrushResource] = Brushes.Red;
        }
    }
}
