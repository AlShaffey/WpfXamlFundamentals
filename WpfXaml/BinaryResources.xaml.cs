using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for BinaryResources.xaml
    /// </summary>
    public partial class BinaryResources : Window
    {
        public BinaryResources()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var assembly = GetType().Assembly;

            Stream stream = assembly.GetManifestResourceStream($"WpfXaml.Images.ALL.png");

            var decoder = new PngBitmapDecoder(
                stream
                ,
                BitmapCreateOptions.None
                ,
                BitmapCacheOption.Default);

            embdedImg.Source = decoder.Frames.First();
        }
    }
}
