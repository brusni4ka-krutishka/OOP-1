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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab6_7
{
    public partial class LimitedInputUserControl : UserControl
    {
        public static readonly RoutedEvent ClickEvent;
        public static readonly RoutedEvent PreviewClickEvent;

        public LimitedInputUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        static LimitedInputUserControl()
        {
            FrameworkPropertyMetadata titleMetadata = new FrameworkPropertyMetadata
            {
                CoerceValueCallback = new CoerceValueCallback(TitleCorrect),
                DefaultValue = ""
            };
            TitleProperty = DependencyProperty.Register(
                        "Title",
                        typeof(string),
                        typeof(LimitedInputUserControl),
                        titleMetadata,
                        new ValidateValueCallback(TitleValidate));

            MaxLengthProperty = DependencyProperty.Register(
                        "MaxLength",
                        typeof(int),
                        typeof(LimitedInputUserControl),
                        new FrameworkPropertyMetadata(),
                        new ValidateValueCallback(MaxLengthValidate));

            ClickEvent = EventManager.RegisterRoutedEvent("Click",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LimitedInputUserControl));
            PreviewClickEvent = EventManager.RegisterRoutedEvent("PreviewClick",
                RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(LimitedInputUserControl));
        }

        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty MaxLengthProperty;

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        protected static bool MaxLengthValidate(object value)
        {
            int maxLength = (int)value;
            if (maxLength < 0)
                return false;
            return true;
        }

        protected static bool TitleValidate(object value)
        {
            string title = (string)value;
            if (title.Length > 150)
                return false;
            return true;
        }
        protected static object TitleCorrect(DependencyObject element, object value)
        {
            string title = (string)value;
            if (title.EndsWith("Property"))
            {
                title.Replace("Property", "");
            }
            return title;
        }

        public event RoutedEventHandler Click
        {
            add
            {
                base.AddHandler(LimitedInputUserControl.ClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(LimitedInputUserControl.ClickEvent, value);
            }
        }
        public event RoutedEventHandler PreviewClick
        {
            add
            {
                base.AddHandler(LimitedInputUserControl.PreviewClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(LimitedInputUserControl.PreviewClickEvent, value);
            }
        }
    }
}