#pragma checksum "..\..\..\..\Page\Jasa\AddEditItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "60783D220C81FB6DA148D2AAAB8128303AE28B9691F98FF43E164DC2D494E3A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using COD_Market_Office.Page.Item;
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


namespace COD_Market_Office.Page.Jasa {
    
    
    /// <summary>
    /// AddEditItem
    /// </summary>
    public partial class AddEditItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSize;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBarcode;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPPN;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbVisible;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/COD Market Office;component/page/jasa/addedititem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
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
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnSelect = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.btnSelectClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblSize = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbBarcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbPPN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbVisible = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Page\Jasa\AddEditItem.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSaveClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

