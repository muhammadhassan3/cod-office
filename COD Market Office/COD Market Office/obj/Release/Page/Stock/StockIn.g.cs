﻿#pragma checksum "..\..\..\..\Page\Stock\StockIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8BE02437FA0281A21F3BE77CA1C0ACAABA8450D44075D15E3DA23FB818D0FD95"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using COD_Market_Office.Page.Stock;
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


namespace COD_Market_Office.Page.Stock {
    
    
    /// <summary>
    /// StockIn
    /// </summary>
    public partial class StockIn : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Page\Stock\StockIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOutlet;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Page\Stock\StockIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblKat;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Page\Stock\StockIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblMerek;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Page\Stock\StockIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblItem;
        
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
            System.Uri resourceLocater = new System.Uri("/COD Market Office;component/page/stock/stockin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\Stock\StockIn.xaml"
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
            
            #line 21 "..\..\..\..\Page\Stock\StockIn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnBackClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbOutlet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\Page\Stock\StockIn.xaml"
            this.cbOutlet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnOutletChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\..\Page\Stock\StockIn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddStockClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tblKat = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\..\..\Page\Stock\StockIn.xaml"
            this.tblKat.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnKatRowSelected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tblMerek = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\..\Page\Stock\StockIn.xaml"
            this.tblMerek.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMerekRowSelected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tblItem = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\..\..\Page\Stock\StockIn.xaml"
            this.tblItem.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnItemRowSelected);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\..\..\Page\Stock\StockIn.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EditStockClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
