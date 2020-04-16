﻿#pragma checksum "..\..\..\Pages\GroupsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335D24FDB66228E8EE5224427304857C13FE8DB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using ShortBody.Pages;
using ShortBody.Resources.UserControls;
using ShortBody.ValueConverters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ShortBody.Pages {
    
    
    /// <summary>
    /// GroupsPage
    /// </summary>
    public partial class GroupsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 73 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ZoneGrid;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgZoneMembers;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AreaGrid;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAreaMembers;
        
        #line default
        #line hidden
        
        
        #line 333 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GroupGrid;
        
        #line default
        #line hidden
        
        
        #line 397 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgGroupMembers;
        
        #line default
        #line hidden
        
        
        #line 466 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClassGrid;
        
        #line default
        #line hidden
        
        
        #line 530 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgClassMembers;
        
        #line default
        #line hidden
        
        
        #line 596 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MinistryGrid;
        
        #line default
        #line hidden
        
        
        #line 652 "..\..\..\Pages\GroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgMinistryMembers;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/pages/groupspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\GroupsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\Pages\GroupsPage.xaml"
            ((ShortBody.Pages.GroupsPage)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ZoneGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 75 "..\..\..\Pages\GroupsPage.xaml"
            this.ZoneGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgZoneMembers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 129 "..\..\..\Pages\GroupsPage.xaml"
            this.dgZoneMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grids_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AreaGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 200 "..\..\..\Pages\GroupsPage.xaml"
            this.AreaGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgAreaMembers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 268 "..\..\..\Pages\GroupsPage.xaml"
            this.dgAreaMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grids_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GroupGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 334 "..\..\..\Pages\GroupsPage.xaml"
            this.GroupGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgGroupMembers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.ClassGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 467 "..\..\..\Pages\GroupsPage.xaml"
            this.ClassGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgClassMembers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 531 "..\..\..\Pages\GroupsPage.xaml"
            this.dgClassMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grids_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MinistryGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 598 "..\..\..\Pages\GroupsPage.xaml"
            this.MinistryGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgMinistryMembers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 653 "..\..\..\Pages\GroupsPage.xaml"
            this.dgMinistryMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Grids_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
