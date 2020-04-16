﻿#pragma checksum "..\..\..\Pages\FamiliesPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BFE9CCC2EF9995DEB6A4574CB10EB9D60DDDFEE3"
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
    /// FamiliesPage
    /// </summary>
    public partial class FamiliesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Pages\FamiliesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\FamiliesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Pages\FamiliesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow AddFamilyWindow;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Pages\FamiliesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow FamilyWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/pages/familiespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\FamiliesPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.cboSearchBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\Pages\FamiliesPage.xaml"
            this.cboSearchBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Pages\FamiliesPage.xaml"
            this.txtSearchBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtSearchBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 66 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddFamily_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 74 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditFamily_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 81 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainFamilyGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddFamilyWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 7:
            
            #line 159 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 160 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            
            #line 162 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FamilyWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 10:
            
            #line 183 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnFamilyDetails_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 191 "..\..\..\Pages\FamiliesPage.xaml"
            ((System.Windows.Controls.Frame)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Frame_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

