﻿#pragma checksum "..\..\OrderingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D33820F17F51E11132BDD8AA7143740BFDD24629D35EAA7CB356AB65EDD080E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ITMO.ADO.NET.ControlLab_4;
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


namespace ITMO.ADO.NET.ControlLab_4 {
    
    
    /// <summary>
    /// OrderingWindow
    /// </summary>
    public partial class OrderingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderID_tbx;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerID_tbx;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeID_tbx;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipVia_tbx;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Freight_tbx;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipName_tbx;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipAddress_tbx;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipCity_tbx;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipRegion_tbx;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipPostalCode_tbx;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShipCountry_tbx;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_btn1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_btn1;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker order_dp;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker req_dp;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\OrderingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker shipped_dp;
        
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
            System.Uri resourceLocater = new System.Uri("/ITMO.ADO.NET.ControlLab_4;component/orderingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrderingWindow.xaml"
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
            this.OrderID_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CustomerID_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EmployeeID_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ShipVia_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Freight_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ShipName_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ShipAddress_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ShipCity_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ShipRegion_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ShipPostalCode_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.ShipCountry_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.add_btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\OrderingWindow.xaml"
            this.add_btn1.Click += new System.Windows.RoutedEventHandler(this.add_btn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cancel_btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\OrderingWindow.xaml"
            this.cancel_btn1.Click += new System.Windows.RoutedEventHandler(this.cancel_btn_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 63 "..\..\OrderingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.order_dp = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 16:
            this.req_dp = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 17:
            this.shipped_dp = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

