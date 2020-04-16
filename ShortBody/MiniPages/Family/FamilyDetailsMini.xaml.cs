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

namespace ShortBody.MiniPages.Family
{
    /// <summary>
    /// Interaction logic for FamilyDetailsMini.xaml
    /// </summary>
    /// 
    public partial class FamilyDetailsMini : UserControl
    {
        public static FamilyDetailsMini familyDetailsMini;
        public FamilyDetailsMini()
        {
            InitializeComponent();
            DataContext = FamiliesPage.familiesPage.viewModel;
            familyDetailsMini = this;   
        }
    }
}
