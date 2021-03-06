﻿using System;
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

namespace WpfXaml.Masters
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfXaml.Masters"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfXaml.Masters;assembly=WpfXaml.Masters"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class MasterControl : Control
    {
        private static readonly Type type = typeof(object);
        private static readonly Type masterControlType = typeof(MasterControl);

        public static readonly DependencyProperty ContentProperty
            = DependencyProperty.Register(nameof(Content), type, masterControlType, new UIPropertyMetadata());
        public static readonly DependencyProperty DescriptionProperty
            = DependencyProperty.Register(nameof(Description), type, masterControlType, new UIPropertyMetadata());

        public object Content
        {
            get
            {
                return GetValue(ContentProperty);
            }
            set
            {
                SetValue(ContentProperty, value);
            }
        }

        public object Description
        {
            get
            {
                return GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }
        static MasterControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MasterControl), new FrameworkPropertyMetadata(typeof(MasterControl)));
        }
    }
}
