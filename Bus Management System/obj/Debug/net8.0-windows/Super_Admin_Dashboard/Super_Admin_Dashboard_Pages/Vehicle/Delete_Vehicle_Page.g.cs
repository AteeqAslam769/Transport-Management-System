﻿#pragma checksum "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\Delete_Vehicle_Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94620432FC9A00E7B86C4DF5BC091F6EC6E78702"
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
using Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Vehicle;


namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Vehicle {
    
    
    /// <summary>
    /// Delete_Vehicle_Page
    /// </summary>
    public partial class Delete_Vehicle_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\Delete_Vehicle_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VehicleIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\Delete_Vehicle_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VehicleTypeTextBox;
        
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
                    "d_pages/vehicle/delete_vehicle_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\Delete_Vehicle_Page.xaml"
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
            this.VehicleIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.VehicleTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 42 "..\..\..\..\..\..\Super_Admin_Dashboard\Super_Admin_Dashboard_Pages\Vehicle\Delete_Vehicle_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Vehicle);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

