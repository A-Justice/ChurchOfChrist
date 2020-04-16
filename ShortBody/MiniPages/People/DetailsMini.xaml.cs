using ShortBody.Pages;
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

namespace ShortBody.MiniPages
{
    /// <summary>
    /// Interaction logic for DetailsMini.xaml
    /// </summary>
    public partial class DetailsMini : UserControl
    {
        public static UserControl detailsMini;
        public DetailsMini()
        {
            InitializeComponent();
            DataContext = PeoplePage.peoplePage.viewModel;
            detailsMini = this;
        }
    }
}
