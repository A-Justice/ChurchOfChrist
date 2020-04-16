using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Resources.UserControls
{
    public partial class MiniWindowControl : ContentControl
    {

        public MiniWindowControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MiniWindowControl), new
           FrameworkPropertyMetadata(typeof(MiniWindowControl)));
        }
        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set
            {
                SetValue(CanCloseProperty, value);

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

  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resize();

        }

        public void Resize()
        {
            if (CanClose)
            {
                if (this.Visibility == Visibility.Collapsed)
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
