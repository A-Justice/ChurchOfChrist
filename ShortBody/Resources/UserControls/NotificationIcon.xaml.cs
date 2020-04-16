using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Resources.UserControls
{
    /// <summary>
    /// Interaction logic for NotificationIcon.xaml
    /// </summary>
    public partial class NotificationIcon : Button
    {





        public bool BadgeVisibility
        {
            get { return (bool)GetValue(BadgeVisibilityProperty); }
            set { SetValue(BadgeVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BadgeVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BadgeVisibilityProperty =
            DependencyProperty.Register("BadgeVisibility", typeof(bool), typeof(NotificationIcon), new PropertyMetadata(false));




        public string Count
        {
            get { return (string)GetValue(CountProperty); }
            set
            {
                SetValue(CountProperty, value);
                if (value == "")
                    BadgeVisibility = false;
                else
                    BadgeVisibility = true;
            }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(string), typeof(NotificationIcon), new PropertyMetadata(""));





        public NotificationIcon()
        {
            InitializeComponent();
        }
    }
}
