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
    /// Interaction logic for LinedButton.xaml
    /// </summary>
    public partial class LinedButton : Button
    {



        public bool ShowLine
        {
            get { return (bool)GetValue(ShowLineProperty); }
            set { SetValue(ShowLineProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowLine.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowLineProperty =
            DependencyProperty.Register("ShowLine", typeof(bool), typeof(LinedButton), new PropertyMetadata(false));


        public LinedButton()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
        }
    }
}
