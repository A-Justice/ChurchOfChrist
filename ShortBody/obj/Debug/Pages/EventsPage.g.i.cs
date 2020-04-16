﻿#pragma checksum "..\..\..\Pages\EventsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4CA8E4F5387A47D350D6576605AE606DD1F79558"
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
    /// EventsPage
    /// </summary>
    public partial class EventsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchMonth;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchDay;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchYear;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow AddEventWindow;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\Pages\EventsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.miniWindow EventWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/pages/eventspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EventsPage.xaml"
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
            
            #line 41 "..\..\..\Pages\EventsPage.xaml"
            this.cboSearchBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboSearchMonth = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cboSearchDay = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cboSearchYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 101 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddEvent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 109 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditEvent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 116 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainEventGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddEventWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 9:
            
            #line 174 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 175 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            
            #line 177 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Button_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EventWindow = ((ShortBody.Resources.UserControls.miniWindow)(target));
            return;
            case 12:
            
            #line 199 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDetails_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 204 "..\..\..\Pages\EventsPage.xaml"
            ((System.Windows.Controls.Frame)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Frame_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

