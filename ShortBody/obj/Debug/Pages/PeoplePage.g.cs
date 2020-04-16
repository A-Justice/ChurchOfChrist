﻿#pragma checksum "..\..\..\Pages\PeoplePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9D34F9AEC59EA70326AAEE9A646BC2FA087C064"
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
using ShortBody.Resources.Helper_Methods;
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
    /// PeoplePage
    /// </summary>
    public partial class PeoplePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Pages\PeoplePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\PeoplePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Pages\PeoplePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow AddPersonWindow;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\Pages\PeoplePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow PersonWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/pages/peoplepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PeoplePage.xaml"
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
            
            #line 40 "..\..\..\Pages\PeoplePage.xaml"
            this.cboSearchBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Pages\PeoplePage.xaml"
            this.txtSearchBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtSearchBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 74 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddPerson_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 82 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditPerson_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 89 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainPersonGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddPersonWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 7:
            
            #line 187 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboService_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 205 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.TextBlock)(target)).Loaded += new System.Windows.RoutedEventHandler(this.TextBlock_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 215 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.ComboBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.cboFamily_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 224 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.ComboBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.cboAssociation_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 246 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 247 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            
            #line 249 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 13:
            this.PersonWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 14:
            
            #line 270 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDetails_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 274 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnFamily_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 278 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnServices_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 285 "..\..\..\Pages\PeoplePage.xaml"
            ((System.Windows.Controls.Frame)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Frame_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

