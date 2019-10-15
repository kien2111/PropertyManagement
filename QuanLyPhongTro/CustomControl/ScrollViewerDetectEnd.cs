using QuanLyPhongTro.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyPhongTro.CustomControl
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:QuanLyPhongTro.CustomControl"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:QuanLyPhongTro.CustomControl;assembly=QuanLyPhongTro.CustomControl"
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
    ///     <MyNamespace:ScrollViewerDetectEnd/>
    ///
    /// </summary>
    
    public class ScrollViewerDetectEnd : ListView
    {
        private Delegate _ListviewScrollChangedHandler;
        static ScrollViewerDetectEnd()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ScrollViewerDetectEnd), new FrameworkPropertyMetadata(typeof(ScrollViewerDetectEnd)));
            ItemsSourceProperty.OverrideMetadata(typeof(ScrollViewerDetectEnd), new FrameworkPropertyMetadata(null));
            ItemsPanelProperty.OverrideMetadata(typeof(ScrollViewerDetectEnd), new FrameworkPropertyMetadata(null));
        }
        public static readonly DependencyProperty CommandProp = DependencyProperty.Register("Command", typeof(ICommand), typeof(ScrollViewerDetectEnd), new PropertyMetadata(new DummyCommand(), OnCommandChanged));
        public static readonly DependencyProperty CommandParamProp = DependencyProperty.Register("CommandParam", typeof(object), typeof(ScrollViewerDetectEnd), new PropertyMetadata(new object(), OnCommandParamChanged));    
        private static void OnCommandChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ScrollViewerDetectEnd listview = o as ScrollViewerDetectEnd;
            if (listview == null) return;
            listview._ListviewScrollChangedHandler = new ScrollChangedEventHandler(HandleScrollChanged);
            if (listview._ListviewScrollChangedHandler != null)
            {
                listview.AddHandler(ScrollViewer.ScrollChangedEvent, listview._ListviewScrollChangedHandler);
            }
            listview.RaiseCommandChanged(e);
        }

        private static void OnCommandParamChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ScrollViewerDetectEnd listview = o as ScrollViewerDetectEnd;
            if (listview == null) return;
            if (listview._ListviewScrollChangedHandler != null)
            {
                listview.AddHandler(ScrollViewer.ScrollChangedEvent, listview._ListviewScrollChangedHandler);
            }
            
            listview.RaiseCommandParamChanged(e);
        }

        private static void HandleScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            
            ScrollBar sb = e.OriginalSource as ScrollBar;
            ScrollViewerDetectEnd listview = sender as ScrollViewerDetectEnd;
            if (sb.Orientation == Orientation.Horizontal) return;
            if (sb.Value == sb.Maximum && listview.CommandParameter != null)
            {
                if (listview.Command.CanExecute(listview.CommandParameter))
                {
                    listview.Command.Execute(listview.CommandParameter);
                }
            }
        }

        public object CommandParameter { get { return GetValue(CommandParamProp); } set { SetValue(CommandParamProp, value); } }

        public ICommand Command { get { return (ICommand)GetValue(CommandProp); } set { SetValue(CommandProp, value); } }

        private void RaiseCommandChanged(DependencyPropertyChangedEventArgs e)
        {

        }
        private void RaiseCommandParamChanged(DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
