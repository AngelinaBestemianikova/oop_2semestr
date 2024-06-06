using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace lab7
{
    public partial class UCMember : UserControl
    {
        public UCMember()
        {
            InitializeComponent();
            this.DataContext = this;
            Loaded += UCMember_Loaded;

            this.AddHandler(DirectEventMember, new RoutedEventHandler(UCMember_Direct));
            this.AddHandler(TunnelingEventMember, new RoutedEventHandler(UCMember_Tunneling));
            this.AddHandler(BubblingEventMember, new RoutedEventHandler(UCMember_Bubbling));
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string SubTitle
        {
            get { return (string)GetValue(SubTitleProperty); }
            set { SetValue(SubTitleProperty, value); }
        }

        public string URL
        {
            get { return (string)GetValue(URLProperty); }
            set { SetValue(URLProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(UCMember),
                new FrameworkPropertyMetadata(string.Empty, null, CoerceTitleValue),
                ValidateTitleValue);

        public static readonly DependencyProperty SubTitleProperty =
            DependencyProperty.Register("SubTitle", typeof(string), typeof(UCMember),
                new FrameworkPropertyMetadata(string.Empty));

        public static readonly DependencyProperty URLProperty =
            DependencyProperty.Register("URL", typeof(string), typeof(UCMember));

        private static bool ValidateTitleValue(object value)
        {
            if (value is string)
            {
                return true;
            }

            return false;
        }

        private static object CoerceTitleValue(DependencyObject d, object baseValue)
        {
            string title = (string)baseValue;

            if (!string.IsNullOrEmpty(title) && char.IsLower(title[0]))
            {
                title = char.ToUpper(title[0]) + title.Substring(1);
            }

            return title;
        }


        private void UCMember_Loaded(object sender, RoutedEventArgs e)
        {
            SubTitle = MethodSubTitlePropertyValue(SubTitle);
        }

        private static string MethodSubTitlePropertyValue(string subTitle)
        {
            return Regex.Replace(subTitle, @"\d", "!");
        }



        public static readonly RoutedEvent DirectEventMember = EventManager.RegisterRoutedEvent(
            "DirectUCMember",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(UCMember));

        public static readonly RoutedEvent TunnelingEventMember = EventManager.RegisterRoutedEvent(
            "TunnelingUCMember",
            RoutingStrategy.Tunnel,
            typeof(RoutedEventHandler),
            typeof(UCMember));

        public static readonly RoutedEvent BubblingEventMember = EventManager.RegisterRoutedEvent(
            "BubblingUCMember",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(UCMember));

        public event RoutedEventHandler DirectMember
        {
            add { AddHandler(DirectEventMember, value); }
            remove { RemoveHandler(DirectEventMember, value); }
        }

        public event RoutedEventHandler TunnelingMember
        {
            add { AddHandler(TunnelingEventMember, value); }
            remove { RemoveHandler(TunnelingEventMember, value); }
        }

        public event RoutedEventHandler BubblingMember
        {
            add { AddHandler(BubblingEventMember, value); }
            remove { RemoveHandler(BubblingEventMember, value); }
        }

        private void UCMember_Direct(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct event UCMember occurred");
            member.FontSize = 12;
        }

        private void UCMember_Tunneling(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tunneling event UCMember occurred");
            member.FontSize = 9;
        }

        private void UCMember_Bubbling(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling event UCMember occurred");
            member.FontSize = 6;
        }

        private void Title_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs directEventArgs = new RoutedEventArgs(DirectEventMember, this);
            RaiseEvent(directEventArgs);

            RoutedEventArgs tunnelingEventArgs = new RoutedEventArgs(TunnelingEventMember, this);
            RaiseEvent(tunnelingEventArgs);

            RoutedEventArgs bubblingEventArgs = new RoutedEventArgs(BubblingEventMember, this);
            RaiseEvent(bubblingEventArgs);

        }

    }
}