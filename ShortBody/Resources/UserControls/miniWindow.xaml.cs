using ShortBody.UViewModels;
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

namespace ShortBody.Resources.UserControls
{
    /// <summary>
    /// Interaction logic for miniWindow.xaml
    /// </summary>
    public partial class miniWindow : UserControl
    {


        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set { SetValue(CanCloseProperty, value);

            }
        }

        // Using a DependencyProperty as the backing store for HeaderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(object), typeof(miniWindow), new PropertyMetadata(true));

        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(miniWindow), new PropertyMetadata("miniWindow"));


        public object Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(miniWindow), new PropertyMetadata(null));

        //public static readonly DependencyProperty HeaderTextProperty =
        //  DependencyProperty.RegisterAttached("HeaderText", typeof(string), typeof(UserControl), new PropertyMetadata("miniWindow"));

        public miniWindow()
        {
            InitializeComponent();
            // DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resize();

        }

        public void Resize()
        {
            if (CanClose)
            {
                if( this.Visibility == Visibility.Collapsed)
                {
                    Visibility = Visibility.Visible;
                }
                else
                {
                    Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
