﻿#pragma checksum "..\..\..\Reports\ZoneReport.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CFC2031A4A8D7788F5E614585A81A7BBD048F08"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ShortBody.Reports;
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


namespace ShortBody.Reports {
    
    
    /// <summary>
    /// ZoneReport
    /// </summary>
    public partial class ZoneReport : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Reports\ZoneReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShortBody.Resources.UserControls.DocumentControl ZoneDocumentControl;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/reports/zonereport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reports\ZoneReport.xaml"
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
            
            #line 8 "..\..\..\Reports\ZoneReport.xaml"
            ((ShortBody.Reports.ZoneReport)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ZoneDocumentControl = ((ShortBody.Resources.UserControls.DocumentControl)(target));
            return;
            case 3:
            
            #line 19 "..\..\..\Reports\ZoneReport.xaml"
            ((System.Windows.Controls.TextBlock)(target)).Loaded += new System.Windows.RoutedEventHandler(this.stpTertiary_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\Reports\ZoneReport.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.stpPrimary_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\..\Reports\ZoneReport.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.stpHalf_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\..\Reports\ZoneReport.xaml"
            ((System.Windows.Controls.StackPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.stpQuarter_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

