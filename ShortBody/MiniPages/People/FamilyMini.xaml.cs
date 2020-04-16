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
    /// Interaction logic for FamilyMini.xaml
    /// </summary>
    public partial class FamilyMini : UserControl
    {
        public static UserControl familyMini;
        public FamilyMini()
        {
            InitializeComponent();
            familyMini = this;
            DataContext = PeoplePage.peoplePage.viewModel;
        }
    }
}
