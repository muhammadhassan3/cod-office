﻿#pragma checksum "..\..\..\..\Page\Order\OrderProcessing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B60D941382EFC10821B6C4877719660CE47B2E2F1DCE341328EA5EEC3FA7CB67"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using COD_Market_Office.Model.Outlet;
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


namespace COD_Market_Office.Model.Outlet {
    
    
    /// <summary>
    /// OrderProcessing
    /// </summary>
    public partial class OrderProcessing : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOutlet;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblWaiting;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblOnProcess;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblWaitingCourrier;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblOnDelivery;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblArrive;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Page\Order\OrderProcessing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblDetail;
        
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
            System.Uri resourceLocater = new System.Uri("/COD Market Office;component/page/order/orderprocessing.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\Order\OrderProcessing.xaml"
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
            
            #line 24 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnBackPressed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbOutlet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.cbOutlet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnOutletSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            
            #line 27 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnStatusSelected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tblWaiting = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tblWaiting.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnRowClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tblOnProcess = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tblOnProcess.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnRowClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tblWaitingCourrier = ((System.Windows.Controls.DataGrid)(target));
            
            #line 53 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tblWaitingCourrier.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnRowClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tblOnDelivery = ((System.Windows.Controls.DataGrid)(target));
            
            #line 65 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tblOnDelivery.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnRowClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tblArrive = ((System.Windows.Controls.DataGrid)(target));
            
            #line 77 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            this.tblArrive.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnRowClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tblDetail = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 101 "..\..\..\..\Page\Order\OrderProcessing.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnProcessClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
