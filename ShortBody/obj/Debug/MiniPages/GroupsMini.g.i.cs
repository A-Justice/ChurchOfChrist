﻿#pragma checksum "..\..\..\MiniPages\GroupsMini.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A5486917CDDD5268E5A66D5F8BD5C09F090CF18"
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
using ShortBody.MiniPages;
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


namespace ShortBody.MiniPages {
    
    
    /// <summary>
    /// GroupsMini
    /// </summary>
    public partial class GroupsMini : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboGroup;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveGroup;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboArea;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveArea;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPMinistries;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboMinistry;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\MiniPages\GroupsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMinistry;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/minipages/groupsmini.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MiniPages\GroupsMini.xaml"
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
            this.cboGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\MiniPages\GroupsMini.xaml"
            this.cboGroup.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSaveGroup = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\MiniPages\GroupsMini.xaml"
            this.btnSaveGroup.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboArea = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\MiniPages\GroupsMini.xaml"
            this.cboArea.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSaveArea = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\MiniPages\GroupsMini.xaml"
            this.btnSaveArea.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgPMinistries = ((System.Windows.Controls.DataGrid)(target));
            
            #line 65 "..\..\..\MiniPages\GroupsMini.xaml"
            this.dgPMinistries.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgPMinistries_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cboMinistry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\MiniPages\GroupsMini.xaml"
            this.cboMinistry.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddMinistry = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

