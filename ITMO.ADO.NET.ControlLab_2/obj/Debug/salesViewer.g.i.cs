﻿#pragma checksum "..\..\salesViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA52BE004C45A7125A1E756DA9850B3812F0A0E8D90B96D75486E7595773BFF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ITMO.ADO.NET.ControlLab_1;
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


namespace ITMO.ADO.NET.ControlLab_1 {
    
    
    /// <summary>
    /// salesViewer
    /// </summary>
    public partial class salesViewer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SalesViewer;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowMonthSales;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowQuorterSales;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowSelectedDates;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerStart;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerEnd;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\salesViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button About_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/ITMO.ADO.NET.ControlLab_2;component/salesviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\salesViewer.xaml"
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
            this.SalesViewer = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\salesViewer.xaml"
            this.SalesViewer.Loaded += new System.Windows.RoutedEventHandler(this.SalesViewer_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ShowMonthSales = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\salesViewer.xaml"
            this.ShowMonthSales.Click += new System.Windows.RoutedEventHandler(this.ShowMonthSales_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowQuorterSales = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\salesViewer.xaml"
            this.ShowQuorterSales.Click += new System.Windows.RoutedEventHandler(this.ShowQuorterSales_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowSelectedDates = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\salesViewer.xaml"
            this.ShowSelectedDates.Click += new System.Windows.RoutedEventHandler(this.ShowSelectedDates_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datePickerStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.datePickerEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.About_btn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

