using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace lab7
{
    /// <summary>
    /// Логика взаимодействия для SpoilerControl.xaml
    /// </summary>
    public partial class SpoilerControl : UserControl
    {
        public SpoilerControl()
        {
            InitializeComponent();

            this.AddHandler(DirectEvent, new RoutedEventHandler(SpoilerControl_Direct));
            this.AddHandler(TunnelingEvent, new RoutedEventHandler(SpoilerControl_Tunneling));
            this.AddHandler(BubblingEvent, new RoutedEventHandler(SpoilerControl_Bubbling));
        }

        public object Secret
        {
            get { return (object)GetValue(SecretProperty); }
            set { SetValue(SecretProperty, value); }
        }

        public string AdditionalProperty
        {
            get { return (string)GetValue(AdditionalPropertyProperty); }
            set { SetValue(AdditionalPropertyProperty, value); }
        }

        public static readonly DependencyProperty SecretProperty =
            DependencyProperty.Register("Secret", typeof(object), typeof(SpoilerControl), 
                new PropertyMetadata("Nothing", OnAdditionalPropertyChanged, CoerceSecretValue), ValidateSecretValue);

        public static readonly DependencyProperty AdditionalPropertyProperty =
            DependencyProperty.Register("AdditionalProperty", typeof(string), typeof(SpoilerControl));

        private static bool ValidateSecretValue(object value)
        {
            if (value is string)
            {
                return true;
            }

            return false;
        }

        private static object CoerceSecretValue(DependencyObject d, object baseValue)
        {
            if (baseValue is string str)
            {
                str = Regex.Replace(str, @"\d", "!");
                return MethodAdditionalPropertyValue(str.ToString());
            }

            return MethodAdditionalPropertyValue(baseValue.ToString());
        }

        private static string MethodAdditionalPropertyValue(string baseValue)
        {

            return Regex.Replace(baseValue, "[*]+", "-");
        }

        private static void OnAdditionalPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var spoilerControl = (SpoilerControl)d;
            spoilerControl.AdditionalProperty = MethodAdditionalPropertyValue(e.NewValue.ToString());
        }




        public static readonly RoutedEvent DirectEvent = EventManager.RegisterRoutedEvent(
            "Direct",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(SpoilerControl));

        public static readonly RoutedEvent TunnelingEvent = EventManager.RegisterRoutedEvent(
            "Tunneling",
            RoutingStrategy.Tunnel,
            typeof(RoutedEventHandler),
            typeof(SpoilerControl));

        public static readonly RoutedEvent BubblingEvent = EventManager.RegisterRoutedEvent(
            "Bubbling",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(SpoilerControl));

        public event RoutedEventHandler Direct
        {
            add { AddHandler(DirectEvent, value); }
            remove { RemoveHandler(DirectEvent, value); }
        }

        public event RoutedEventHandler Tunneling
        {
            add { AddHandler(TunnelingEvent, value); }
            remove { RemoveHandler(TunnelingEvent, value); }
        }

        public event RoutedEventHandler Bubbling
        {
            add { AddHandler(BubblingEvent, value); }
            remove { RemoveHandler(BubblingEvent, value); }
        }

        private void Spoiler_Click(object sender, RoutedEventArgs e)
        {
            if (spoilerGrid.Visibility == Visibility.Visible)
            {
                contentGrid.Visibility = Visibility.Visible;
                spoilerGrid.Visibility = Visibility.Collapsed;

                RoutedEventArgs directEventArgs = new RoutedEventArgs(DirectEvent, this);
                RaiseEvent(directEventArgs);

                RoutedEventArgs tunnelingEventArgs = new RoutedEventArgs(TunnelingEvent, this);
                RaiseEvent(tunnelingEventArgs);

                RoutedEventArgs bubblingEventArgs = new RoutedEventArgs(BubblingEvent, this);
                RaiseEvent(bubblingEventArgs);
            }
            else
            {
                contentGrid.Visibility = Visibility.Collapsed;
                spoilerGrid.Visibility = Visibility.Visible;
            }
        }

        private void SpoilerControl_Direct(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct event occurred");
            buttonHide.BorderBrush = Brushes.RoyalBlue;
            buttonHide.BorderThickness = new Thickness(2, 2, 2, 2);
        }

        private void SpoilerControl_Tunneling(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tunneling event occurred");
            buttonHide.BorderBrush = Brushes.Gray;
            buttonHide.BorderThickness = new Thickness (2, 2, 2, 2);
        }

        private void SpoilerControl_Bubbling(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling event occurred");
            buttonHide.BorderBrush = Brushes.DarkBlue;
            buttonHide.BorderThickness = new Thickness(2, 2, 2, 2);
        }
    }
}
