﻿#pragma checksum "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C2D6BFCD4164F289F2D5D858E573959062A5D1D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages;


namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages {
    
    
    /// <summary>
    /// View_Vehicle_Page
    /// </summary>
    public partial class View_Vehicle_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VehicleTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label VehicleLabel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VehicleGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Transport Management Syatem;component/super_admin_dashboard/super_admin_dashboar" +
                    "d_pages/vehicle/view_vehicles_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 34 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\View_Vehicles_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Vehicle_Search);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VehicleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.VehicleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.VehicleGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

