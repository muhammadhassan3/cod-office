﻿#pragma checksum "..\..\..\..\Page\Stock\AddStock.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBFCCB4590BDFC3712FFFE177E68A05BA2A7A7E11EAA60B60311961E099EF306"
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
    /// AddStock
    /// </summary>
    public partial class AddStock : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgItem;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbGrosir;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMinGrosir;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKeuntunganGrosir;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStok;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbHarga;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKeuntungan;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Page\Stock\AddStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiskon;
        
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
            System.Uri resourceLocater = new System.Uri("/COD Market Office;component/page/stock/addstock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\Stock\AddStock.xaml"
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
            
            #line 19 "..\..\..\..\Page\Stock\AddStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnChooseItemSelected);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgItem = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.cbGrosir = ((System.Windows.Controls.CheckBox)(target));
            
            #line 51 "..\..\..\..\Page\Stock\AddStock.xaml"
            this.cbGrosir.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CbGrosirChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbMinGrosir = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbKeuntunganGrosir = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 56 "..\..\..\..\Page\Stock\AddStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnVerifyClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbStok = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbHarga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbKeuntungan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbDiskon = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

