﻿#pragma checksum "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0A60827AE7A87426FD9556E5C226E9FF71BD72F7"
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
using ShortBody.MiniPages.Event;
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


namespace ShortBody.MiniPages.Event {
    
    
    /// <summary>
    /// EventDetailsMini
    /// </summary>
    public partial class EventDetailsMini : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchMembers;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchMembers;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearchAttendants;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchAttendants;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AllPeopleGrid;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AttendeesGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ShortBody;component/minipages/event/eventdetailsmini.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
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
            this.cboSearchMembers = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.cboSearchMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchMembers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchMembers = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.txtSearchMembers.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtSearchMembers_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboSearchAttendants = ((System.Windows.Controls.ComboBox)(target));
            
            #line 94 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.cboSearchAttendants.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearchAttendants_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSearchAttendants = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.txtSearchAttendants.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtSearchAttendants_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AllPeopleGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 120 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.AllPeopleGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AllPeopleGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AttendeesGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 155 "..\..\..\..\MiniPages\Event\EventDetailsMini.xaml"
            this.AttendeesGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AttendeesGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

