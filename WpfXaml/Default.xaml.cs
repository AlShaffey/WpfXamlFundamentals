using System.Diagnostics;
using System.Windows;

namespace WpfXaml
{
    /// <summary>
    /// Interaction logic for Default.xaml
    /// </summary>
    public partial class Default : Window
    {
        public Default()
        {
            InitializeComponent();
        }

        private void Integration_Click(object sender, RoutedEventArgs e)
        {
            var integration = new Integration();
            integration.Show();
        }

        private void Controls_Click(object sender, RoutedEventArgs e)
        {
            var controls = new Controls();
            controls.Show();
        }

        private void Designers_Click(object sender, RoutedEventArgs e)
        {
            var designers = new Designers();
            designers.Show();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void GroupingControls_Click(object sender, RoutedEventArgs e)
        {
            var groupingControls  = new GroupingControls();
            groupingControls.Show();
        }

        private void TextInput_Click(object sender, RoutedEventArgs e)
        {
            var textInput = new TextInput();
            textInput.Show();
        }

        private void RangeControls_Click(object sender, RoutedEventArgs e)
        {
            var rangeControls = new RangeControls();
            rangeControls.Show();
        }

        private void ItemControls_Click(object sender, RoutedEventArgs e)
        {
            var itemControls = new ItemControl();
            itemControls.Show();
        }

        private void MoreItemControls_Click(object sender, RoutedEventArgs e)
        {
            var moreItemControls = new MoreItemControls();
            moreItemControls.Show();
        }

        private void ItemContainers_Click(object sender, RoutedEventArgs e)
        {
            var itemContainers = new ItemContainers();
            itemContainers.Show();
        }

        private void EventRouting_Click(object sender, RoutedEventArgs e)
        {
            var eventRouting = new EventRouting();
            eventRouting.Show();
        }

        private void BuiltInCommands_Click(object sender, RoutedEventArgs e)
        {
            var builtInCommands = new BuiltInCommand();
            builtInCommands.Show();
        }

        private void MenusAndCommands_Click(object sender, RoutedEventArgs e)
        {
            var menusAndCommands = new MenusAndCommands();
            menusAndCommands.Show();
        }

        private void Margin_Click(object sender, RoutedEventArgs e)
        {
            var margin = new Margin();
            margin.Show();
        }

        private void Padding_Click(object sender, RoutedEventArgs e)
        {
            var padding = new Padding();
            padding.Show();
        }

        private void Allignment_Click(object sender, RoutedEventArgs e)
        {
            var allignment = new Allignment();
            allignment.Show();
        }

        private void ContentAlignment_Click(object sender, RoutedEventArgs e)
        {
            var contentAlignment = new ContentAlignment();
            contentAlignment.Show();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var grid = new Grid();
            grid.Show();
        }

        private void GridSplitter_Click(object sender, RoutedEventArgs e)
        {
            var gridsplitter = new GridSplitter();
            gridsplitter.Show();
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            var canvas = new Canvas();
            canvas.Show();
        }

        private void Scrollviewer_Click(object sender, RoutedEventArgs e)
        {
            var scrollviewer = new ScrollViewer();
            scrollviewer.Show();
        }

        private void ViewBox_Click(object sender, RoutedEventArgs e)
        {
            var viewBox = new ViewBox();
            viewBox.Show();
        }

        private void Navigation_Click(object sender, RoutedEventArgs e)
        {
            var navigationContainer = new NavigationContainer();
            navigationContainer.Show();
        }

        private void Transformability_Click(object sender, RoutedEventArgs e)
        {
            var transformability = new Transformability();
            transformability.Show();
        }

        private void TileBrush_Click(object sender, RoutedEventArgs e)
        {
            var tileBrush = new TileBrush();
            tileBrush.Show();
        }

        private void Transforms_Click(object sender, RoutedEventArgs e)
        {
            var transforms = new Transforms();
            transforms.Show();
        }

        private void Animation_Click(object sender, RoutedEventArgs e)
        {
            var animation = new Animation();
            animation.Show();
        }

        private void ExplicitDataSource_Click(object sender, RoutedEventArgs e)
        {
            var explicitDataSource = new ExplicitDataSource();
            explicitDataSource.Show();
        }

        private void ExplicitDataSourceAsResource_Click(object sender, RoutedEventArgs e)
        {
            var explicitDataSourceAsResource = new ExplicitDataSourceAsResource();
            explicitDataSourceAsResource.Show();
        }

        private void WithDataContext_Click(object sender, RoutedEventArgs e)
        {
            var withDataContext = new WithDataContext();
            withDataContext.Show();
        }

        private void DataTemplate_Click(object sender, RoutedEventArgs e)
        {
            var dataTemplate = new DataTemplate();
            dataTemplate.Show();
        }

        private void DataTemplateTriggers_Click(object sender, RoutedEventArgs e)
        {
            var dataTemplateTriggers = new DataTemplateTriggers();
            dataTemplateTriggers.Show();
        }

        private void BindingToCollection_Click(object sender, RoutedEventArgs e)
        {
            var bindingToCollection = new BindingToCollection();
            bindingToCollection.Show();
        }

        private void MasterDetail_Click(object sender, RoutedEventArgs e)
        {
            var masterDetail = new MasterDetail();
            masterDetail.Show();
        }

        private void HierarchicalDataBinding_Click(object sender, RoutedEventArgs e)
        {
            var hierarchicalDataBinding = new HierarchicalDataBinding();
            hierarchicalDataBinding.Show();
        }

        private void DataProviders_Click(object sender, RoutedEventArgs e)
        {
            var dataProviders = new DataProviders();
            dataProviders.Show();
        }

        private void XmlNamespaces_Click(object sender, RoutedEventArgs e)
        {
            var xmlNamespaces = new XmlNamespaces();
            xmlNamespaces.Show();
        }

        private void CollectionViews_Click(object sender, RoutedEventArgs e)
        {
            var collectionViews = new CollectionViews();
            collectionViews.Show();
        }

        private void WritingDataSources_Click(object sender, RoutedEventArgs e)
        {
            var writingDataSources = new WritingDataSources();
            writingDataSources.Show();
        }

        private void Converters_Click(object sender, RoutedEventArgs e)
        {
            var converters = new Converters();
            converters.Show();
        }

        private void Validation_Click(object sender, RoutedEventArgs e)
        {
            var validation = new Validation();
            validation.Show();
        }

        private void ControlTemplates_Click(object sender, RoutedEventArgs e)
        {
            var controlTemplates = new ControlTemplates();
            controlTemplates.Show();
        }

        private void TemplateBinding_Click(object sender, RoutedEventArgs e)
        {
            var templateBinding = new TemplateBinding();
            templateBinding.Show();
        }

        private void Triggers_Click(object sender, RoutedEventArgs e)
        {
            var triggers = new Triggers();
            triggers.Show();
        }

        private void TriggerTargeting_Click(object sender, RoutedEventArgs e)
        {
            var triggerTargeting = new TriggerTargeting();
            triggerTargeting.Show();
        }

        private void NamedParts_Click(object sender, RoutedEventArgs e)
        {
            var namedParts = new NamedParts();
            namedParts.Show();
        }

        private void ContentControl_Click(object sender, RoutedEventArgs e)
        {
            var contentControl = new ContentControl();
            contentControl.Show();
        }

        private void ItemControlOptions_Click(object sender, RoutedEventArgs e)
        {
            var itemControlOptions = new ItemControlOptions();
            itemControlOptions.Show();
        }

        private void ItemControlFullTemplate_Click(object sender, RoutedEventArgs e)
        {
            var itemControlFullTemplate = new ItemControlFullTemplate();
            itemControlFullTemplate.Show();
        }

        private void HeaderedItemControl_Click(object sender, RoutedEventArgs e)
        {
            var headeredItemControl = new HeaderedItemControl();
            headeredItemControl.Show();
        }

        private void TemplatesAreFactories_Click(object sender, RoutedEventArgs e)
        {
            var templatesAreFactories = new TemplatesAreFactories();
            templatesAreFactories.Show();
        }

        private void ReusableResources_Click(object sender, RoutedEventArgs e)
        {
            var reusableResources = new ReusableResources();
            reusableResources.Show();
        }

        private void DefiningResources_Click(object sender, RoutedEventArgs e)
        {
            var definingResources = new DefiningResources();
            definingResources.Show();
        }

        private void ResourceReferences_Click(object sender, RoutedEventArgs e)
        {
            var resourceReferences = new ResourceReferences();
            resourceReferences.Show();
        }

        private void ResourceHierarchy_Click(object sender, RoutedEventArgs e)
        {
            var resourceHierarchy = new ResourceHierarchy();
            resourceHierarchy.Show();
        }

        private void AlternateReferenceSyntax_Click(object sender, RoutedEventArgs e)
        {
            var alternateReferenceSyntax = new AlternateReferenceSyntax();
            alternateReferenceSyntax.Show();
        }

        private void ImplicitResourceUsage_Click(object sender, RoutedEventArgs e)
        {
            var implicitResourceUsage = new ImplicitResourceUsage();
            implicitResourceUsage.Show();
        }

        private void MergingResources_Click(object sender, RoutedEventArgs e)
        {
            var mergingResources = new MergingResources();
            mergingResources.Show();
        }

        private void BinaryResources_Click(object sender, RoutedEventArgs e)
        {
            var binaryResources = new BinaryResources();
            binaryResources.Show();
        }

        private void ImageSource_Click(object sender, RoutedEventArgs e)
        {
            var imageSource = new ImageSource();
            imageSource.Show();
        }

        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            var textBlock = new TextBlock();
            textBlock.Show();
        }

        private void InlineTextHints_Click(object sender, RoutedEventArgs e)
        {
            var inlineTextHints = new InlineTextHints();
            inlineTextHints.Show();
        }

        private void DocumentViewerControls_Click(object sender, RoutedEventArgs e)
        {
            var documentViewerControls = new DocumentViewerControls();
            documentViewerControls.Show();
        }

        private void Paragraph_Click(object sender, RoutedEventArgs e)
        {
            var paragraph = new Paragraph();
            paragraph.Show();
        }

        private void Section_Click(object sender, RoutedEventArgs e)
        {
            var section = new Section();
            section.Show();
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            var list = new List();
            list.Show();
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            var table = new Table();
            table.Show();
        }

        private void Floater_Click(object sender, RoutedEventArgs e)
        {
            var floater = new Floater();
            floater.Show();
        }

        private void Figure_Click(object sender, RoutedEventArgs e)
        {
            var figure = new Figure();
            figure.Show();
        }

        private void Typography_Click(object sender, RoutedEventArgs e)
        {
            var typography = new Typography();
            typography.Show();
        }
    }
}
